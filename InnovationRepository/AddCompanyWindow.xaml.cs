using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InnovationRepository
{
    /// <summary>
    /// Interaction logic for AddCompanyWindow.xaml
    /// </summary>
    public partial class AddCompanyWindow : Window
    {
        Entities context = new Entities();
        public AddCompanyWindow()
        {
            InitializeComponent();
            LoadWindow();
        }

        void LoadWindow()
        {
            //town addedTown = new town();
            //addedTown.town1 = "Kopyls12";
            //context.towns.Add(addedTown);
            //context.SaveChanges();
            List<town> myTowns = context.towns.ToList();
            foreach (var town in myTowns)
            {
                townBox.Items.Add(town.town1.ToString());
            }
        }
    }
}
