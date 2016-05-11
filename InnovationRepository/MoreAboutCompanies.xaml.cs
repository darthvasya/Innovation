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
    /// Interaction logic for MoreAboutCompanies.xaml
    /// </summary>
    public partial class MoreAboutCompanies : Window
    {
        public MoreAboutCompanies()
        {
            InitializeComponent();

            Entities context = new Entities();

            dataGrid.ItemsSource = context.InformationAboutCompanies.ToList(); // устанавливаем привязку к кэшу

             
        }

        

        private void companysGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
