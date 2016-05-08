using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace InnovationRepository
{
    public class MyCompany : IObject
    {
        protected string address;
        protected string Name;

        public MyCompany(string _address, string _name)
        {
            this.address = _address;
            this.Name = _name;
        }

        public string errMessage{
           get { return "Error in MyCompany class"; }
        }

        public string name
        {
            get { return Name; }
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
    }
}