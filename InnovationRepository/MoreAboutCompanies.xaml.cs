using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
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

    public class Phone
    {
        public int Id { get; set; }
        public string Title { get; set; } // модель телефона
        public string Company { get; set; } // производитель
        public string ImagePath { get; set; } // путь к изображению
    }
    
    public partial class MoreAboutCompanies : Window
    {
        //List<string> phones;

        public ObservableCollection<InformationAboutCompany> Companys { get; set; }
        public MoreAboutCompanies()
        {
            InitializeComponent();
            LoadList();
        }

        void LoadList()
        {
            Companys = new ObservableCollection<InformationAboutCompany>();
            Entities context = new Entities();
            var x = from p in context.InformationAboutCompanies select p;
            foreach (var p in x)
            {
                Companys.Add(p);
            }
            myList.ItemsSource = Companys;
            
        }

        private void myList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InformationAboutCompany p = (InformationAboutCompany)myList.SelectedItem;
            MyCompany.selectedCompany = p.ID_company;
            CompanyWindow compWindow = new CompanyWindow();
            compWindow.Show();

        }
    }
}
