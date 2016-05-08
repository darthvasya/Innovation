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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InnovationRepository
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadTestEntity();
        }

        private void LoadTestEntity()
        {
            try
            {
                Entities context = new Entities();
                string x = "";
                //foreach (Company cm in context.Companies)
                //{
                //    x += (" | " + cm.name);
                //}

                Company cm = context.Companies.Find(2);
                x = cm.name.ToString();
                MessageBox.Show(x);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyCompany myc = new MyCompany("addres", "FirstName");
            myc.addNewItem();
            myc.getInformation();
            myc.Edit();

            

 
        }
    }
}
