using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace InnovationRepository
{
    public class CompanyCreator : MyCompany
    {
        public static MyCompany instance = new MyCompany();
        public string  Name { get; private set; }
        public CompanyCreator()
        {

        }

        public override void getInformation()
        {
            base.getInformation();
        }

        public override void addNewItem()
        {
            base.addNewItem();
            MessageBox.Show("And some actions from polymorfism");
        }

        public static MyCompany CreateCompany(string Name)
        {
            if(instance == null)
                instance = new MyCompany();
            return instance;
            MessageBox.Show("Company created");
            
        }


    }
}