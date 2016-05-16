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
    /// Interaction logic for RealizationWindow.xaml
    /// </summary>
    public partial class RealizationWindow : Window
    {
        Entities context = new Entities();

        public RealizationWindow()
        {
            InitializeComponent();
        }

        void LoadInfo()
        {
            var promouters = context.contacts.ToList();
            var companys = context.Companies.ToList();
            var innovations = context.Innovations.ToList();

            foreach (var promouter in promouters)
                promoterBox.Items.Add("[" + promouter.ID_contact + "] " + promouter.name + " " + promouter.surname);
            foreach (var company in companys)
                companyBox.Items.Add(company.name);


        }
    }
}
