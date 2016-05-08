using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InnovationRepository
{
    public interface IObject
    {
        string name { get; }
        string errMessage { get; }

        void getInformation();
        void addNewItem();
        void Edit();
    }
}