using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationRepository
{
    interface IObject
    {
        string errMessage { get; set; }

        void getInformation();
        void addNewItem();
        void Edit();
    }
}
