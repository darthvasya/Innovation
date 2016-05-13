using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for MoreAboutInnovationWindow.xaml
    /// </summary>
    public partial class MoreAboutInnovationWindow : Window
    {
        public MoreAboutInnovationWindow()
        {
            InitializeComponent();
            LoadList();
        }

        public ObservableCollection<InformationAboutInnovation> Innovations { get; set; }
        void LoadList()
        {
            Innovations = new ObservableCollection<InformationAboutInnovation>();
            Entities context = new Entities();
            var x = from p in context.InformationAboutInnovations select p;
            foreach (var p in x)
            {
                Innovations.Add(p);
            }
            myListInnovations.ItemsSource = Innovations;
        }

        private void myListInnovations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InformationAboutInnovation p = (InformationAboutInnovation)myListInnovations.SelectedItem;
            MyCompany.selectedInnovation = p.ID_innovation;
            InnovationWindow innovationWindow = new InnovationWindow();
            innovationWindow.Show();
        }
    }
}
