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
    /// Interaction logic for AddContact.xaml
    /// </summary>
    public partial class AddContact : Window
    {
        Entities context = new Entities();

        public AddContact()
        {
            InitializeComponent();
            LoadInfo();
        }

        void LoadInfo()
        {
            List<district> districts = context.districts.ToList();

            foreach (var district in districts)
                districtBox.Items.Add(district.district1.ToString());
        }

        private void saveContactBtn_Click(object sender, RoutedEventArgs e)
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
                MessageBox.Show("Контакт успешно сохранен");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //end work with contact
        }
    }
}
