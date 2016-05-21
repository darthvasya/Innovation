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
            LoadInfo();
        }

        void LoadInfo()
        {
            var promouters = context.contacts.ToList();
            var companys = context.Companies.ToList();
            var innovations = context.Innovations.ToList();
            var states = context.StatesInnovations.ToList();

            foreach (var promouter in promouters)
                promoterBox.Items.Add("[" + promouter.ID_contact + "] " + promouter.name + " " + promouter.surname);
            foreach (var company in companys)
                companyBox.Items.Add(company.name);
            foreach (var innov in innovations)
                innovaBox.Items.Add(innov.Name);
            foreach (var state in states)
                stateBox.Items.Add(state.stateInnvoation);

        }
    }
}
