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
            clearBox();
        }

        void LoadInfo()
        {
            try
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Скорее всего нет соединения с базой данных. Проверьте соединение. Приложение будет закрыто.", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
                Application.Current.Shutdown();
            }
        }

        private void addRealizBtn_Click(object sender, RoutedEventArgs e)
        {
            int idSelectedCompany = context.Companies.Where(p => p.name == companyBox.Text.ToString()).FirstOrDefault().ID_company;
            int idSelectedInnovation = context.Innovations.Where(p => p.Name == innovaBox.Text.ToString()).FirstOrDefault().ID_innovation;

            string x1 = promoterBox.Text.ToString();
            string[] s1 = x1.Split(']');
            s1[0] = s1[0].Replace('[', '0');
            int promoterId = Convert.ToInt32(s1[0]);

            realization myRealization = new realization();
            myRealization.ID_company = idSelectedCompany;
            myRealization.ID_innovation = idSelectedInnovation;
            myRealization.ID_promoter = promoterId;
            myRealization.implementationState = stateBox.Text.ToString();

            try
            {
                context.realizations.Add(myRealization);
                context.SaveChanges();
                MessageBox.Show("Элемент успешно добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void clearBox()
        {
            stateBox.Text = "";
            innovaBox.SelectedIndex = 0;
            companyBox.SelectedIndex = 0;
            promoterBox.SelectedIndex = 0;
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            clearBox();
        }
    }
}
