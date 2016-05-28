using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InnovationRepository
{
    public class MyInnovation : Father, IObject
    {
        Entities context;
        public static int selectedCompanyInnovation { get; set; }
        public static int selectedInnovationInn { get; set; }

        public MyInnovation()
        {

        }
        

        public virtual void addNewItem()
        {
            throw new NotImplementedException();
        }

        public string getError(Exception ex)
        {
            throw new NotImplementedException();
        }

        public virtual  void getInformation()
        {
            throw new NotImplementedException();
        }
    }
}