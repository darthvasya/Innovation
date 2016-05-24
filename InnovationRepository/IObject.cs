﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InnovationRepository
{
    public interface IObject
    {

        void getInformation();
        void addNewItem();
        string getError(Exception ex);
        
    }
}