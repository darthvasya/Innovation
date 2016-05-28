using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace InnovationRepository
{
    public class InnovationCreator : MyInnovation
    {
        public static MyInnovation instance = new MyInnovation();
        public string NameInnovation { get; set; }

        public InnovationCreator()
        {

        }


        public static MyInnovation CrateInnovation(string Name)
        {

            if (instance == null)
                instance = new MyInnovation();
            return instance;
            MessageBox.Show("Company created");
        }
    }
}