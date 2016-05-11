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

        public ObservableCollection<Phone> Phones { get; set; }
        public MoreAboutCompanies()
        {
            InitializeComponent();

            //Entities context = new Entities();

            //phones = new List<string> { "iPhone 6S Plus", "Nexus 6P", "Galaxy S7 Edge12" };

            //phonesList.ItemsSource = phones;
            Phones = new ObservableCollection<Phone>
            {
                new Phone {Id=1, ImagePath="Resources/no2.png", Title="iPhone 6S", Company="Apple" },
                new Phone {Id=2, ImagePath="Resources/no2.png", Title="Lumia 950", Company="Microsoft" },
                new Phone {Id=3, ImagePath="Resources/no2.png", Title="Nexus 5X", Company="Google" },
                new Phone {Id=4, ImagePath="Resources/no2.png", Title="Galaxy S6", Company="Samsung"}
            };
            myList.ItemsSource = Phones;


        }

        private void myList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone p = (Phone)myList.SelectedItem;
            MessageBox.Show(p.Company);
        }
    }
}
