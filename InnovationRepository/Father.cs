using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InnovationRepository
{
    public abstract class Father
    {
        public string errMessage { get; private set; }

        public Father()
        {

        }

        public Father(string typeObj)
        {
            if (typeObj == "Innovation")
                errMessage = "Error with Innovation";
            if (typeObj == "Company")
                errMessage = "Error with Company";
        }
    }
}