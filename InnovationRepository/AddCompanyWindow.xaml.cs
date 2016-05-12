using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InnovationRepository
{
    /// <summary>
    /// Interaction logic for AddCompanyWindow.xaml
    /// </summary>
    public partial class AddCompanyWindow : Window
    {
        Entities context = new Entities();
        public AddCompanyWindow()
        {
            InitializeComponent();
            LoadWindow();
        }

        void LoadWindow()
        {
            //town addedTown = new town();
            //addedTown.town1 = "Kopyls12";
            //context.towns.Add(addedTown);
            //context.SaveChanges();
            //List<town> myTowns = context.towns.ToList();
            //foreach (var town in myTowns)
            //{
            //    townBox.Items.Add(town.town1.ToString());
            //}

            List<Branch> branches = context.Branches.ToList();
            List<Ownersheep> ownersheeps = context.Ownersheep.ToList();
            List<FieldActivity> fieldActivity = context.FieldActivities.ToList();
            List<district> districts = context.districts.ToList();
            List<CompanyState> companyStates = context.CompanyStates.ToList();

            foreach (var branch in branches)
                branchBox.Items.Add(branch.branch1.ToString());
            foreach (var ownersheep in ownersheeps)
                ownersheepBox.Items.Add(ownersheep.ownersheep1.ToString());
            foreach (var fieldActiv in fieldActivity)
                fieldhBox.Items.Add(fieldActiv.fieldActivity1.ToString());
            foreach (var district in districts)
                districtBox.Items.Add(district.district1.ToString());
            foreach (var state in companyStates)
                stateBox.Items.Add(state.companyState1);

        }

        private void saveCompanyBtn_Click(object sender, RoutedEventArgs e)
        {
            addItems();
        }

        void addItems()
        {
            //work with address
            Address myAdress = new Address();
           
            //work with town
            var town = context.towns.Where(p => p.town1 == townBox.Text.ToString()).FirstOrDefault();
            
            if (town != null)
            {
                int indexOfSelectedTown = town.ID_town;
                myAdress.ID_town = indexOfSelectedTown;
            }
            else
            {
                town addedTown = new town();
                addedTown.town1 = townBox.Text.ToString();
                myAdress.town = addedTown;
                context.towns.Add(addedTown);
                context.SaveChanges();
                int savedTownId = context.towns.Where(p => p.town1 == townBox.Text.ToString()).FirstOrDefault().ID_town;
                myAdress.ID_town = savedTownId;
            }
            //end work with town

            //work with district
            if (districtBox.Text != null)
            {
                int selectedDistrictIndex = context.districts.Where(p => p.district1 == districtBox.Text.ToString()).FirstOrDefault().ID_district;
                myAdress.ID_district = selectedDistrictIndex;
                //district distr = new district();
                //distr.district1 = districtBox.Text.ToString();
                //myAdress.district = distr;
            }
            //end work with district

            //work with street, house, flat
            if (streetBox.Text != null)
            {
                myAdress.street = streetBox.Text.ToString();
            }
            if (houseBox.Text != "")
            {
                myAdress.house = houseBox.Text.ToString();
            }
            if (flatBox.Text != "")
            {
                myAdress.flat = Convert.ToInt32(flatBox.Text);
            }

            //get last added address id for ad to contact table


            int idAddedAddress = 0;
            try
            {
                context.Addresses.Add(myAdress);
                context.SaveChanges();
                idAddedAddress = context.Addresses.Take(10000).AsEnumerable().Last().ID_address;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //end work with street, house, flat
            //end work with address

            //work with contact
            contact myContact = new contact();

            int idSelectedCompanyState = context.CompanyStates.Where(p => p.companyState1 == stateBox.Text.ToString()).FirstOrDefault().ID_companyState;
            myContact.ID_CompanyState = idSelectedCompanyState;
            myContact.ID_PersonStatus = 1;

            if (unameBox.Text != null)
                myContact.name = unameBox.Text.ToString();
            if (surnameBox.Text != null)
                myContact.surname = surnameBox.Text.ToString();
            if (secondnameBox.Text != null)
                myContact.secondName = secondnameBox.Text.ToString();
            if (telephoneBox.Text != null)
                myContact.telephone = telephoneBox.Text.ToString();
            if (emailBox.Text != null)
                myContact.email = emailBox.Text.ToString();
            

            try
            {
                myContact.ID_address = idAddedAddress;
                context.contacts.Add(myContact);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //end work with contact


            //work with worksheet
            worksheet myWorksheet = new worksheet();

            if (wareBox.Text != "")
                myWorksheet.ware = wareBox.Text.ToString();

            try
            {
                int idSelectedBranch = context.Branches.Where(p => p.branch1 == branchBox.Text.ToString()).FirstOrDefault().ID_branch;
                int idSelectedOwnersheep = context.Ownersheep.Where(p => p.ownersheep1 == ownersheepBox.Text.ToString()).FirstOrDefault().ID_ownersheep;
                int idSelectedFieldActivity = context.FieldActivities.Where(p => p.fieldActivity1 == fieldhBox.Text.ToString()).FirstOrDefault().ID_fieldActivity;

                myWorksheet.ID_branch = idSelectedBranch;
                myWorksheet.ID_ownership = idSelectedOwnersheep;
                myWorksheet.ID_fieldActivity = idSelectedFieldActivity;

                context.worksheets.Add(myWorksheet);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //end work with worksheet


            //work with company
            int idAddedContact = context.contacts.Take(10000).AsEnumerable().Last().ID_contact;
            int idAddedWorksheet = context.worksheets.Take(10000).AsEnumerable().Last().ID_worksheet;

            Company myCompany = new Company();

            if (nameBox.Text != null)
                myCompany.name = nameBox.Text.ToString();

            myCompany.ID_adress = idAddedAddress;
            myCompany.ID_contact = idAddedContact;
            myCompany.ID_worksheet = idAddedWorksheet;

            try
            {
                context.Companies.Add(myCompany);
                context.SaveChanges();
                MessageBox.Show(myCompany.name.ToString() + " успешно добавлена!" );
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //end work with company

        }
    }
}
