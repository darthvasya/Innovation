using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace InnovationRepository
{
    public class CompanyInRealization : MyCompany
    {
        private Innovation InnovObject;
        private Company CompanyObject;

        public CompanyInRealization(string _address, string _nameCompany, Innovation _innovationObject, Company _companyObject)
            : base(_address, _nameCompany)
        {
            this.Name = _nameCompany;
            this.address = _address;
            this.InnovObject = _innovationObject;
            this.CompanyObject = _companyObject;
        }

        public override void Edit()
        {
            base.Edit(); 
        }

        public override void addNewItem()
        {
            base.addNewItem();
        }

        public override void getInformation()
        {
            base.getInformation();
        }





    }
}