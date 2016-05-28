using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace InnovationRepository
{
    public class InnovationRealization : MyInnovation
    {
        private Innovation InnovObject;
        private Company CompanyObject;

        public InnovationRealization()
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
    }
}