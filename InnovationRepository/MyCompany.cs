using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.ObjectModel;

namespace InnovationRepository
{
    public class MyCompany : IObject
    {
        Entities context;
        public static int selectedCompany {get; set;}

        public MyCompany()
        {
            try
            {
                context = new Entities();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public string errMessage{
           get { return "Error in MyCompany class"; }
        }

 

        public virtual void addNewItem()
        {
            MessageBox.Show("New item aded");
        }

        public virtual void Edit()
        {
            MessageBox.Show("Edit");
        }

        public virtual void getInformation()
        {
            MessageBox.Show("getInformation");
        }

        public InformationAboutCompany getCompany(int idCompany)
        {
           
            return context.InformationAboutCompanies.Find(idCompany); ;
        }

        //public ObservableCollection<Company> getAllCompanies()
        //{
        //    return context.Companies;
        //}
    }
}