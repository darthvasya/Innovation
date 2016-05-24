using InnovationRepository;
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
        Entities context = new Entities();

        public MainWindow()
        {
            InitializeComponent();
            LoadTestEntity();
        }

        private void LoadTestEntity()
        {
            try
            {
                //происходит выборка первых, нужно сделать последних, 
                //мб ид в представление засунуть и по нему сортировать
                List<InformationAboutCompany> comp = (from p in context.InformationAboutCompanies select p).Take(3).ToList();

                nameCompFirst.Text = comp[0].name;
                nameCompSecond.Text = comp[1].name;
                nameCompThird.Text = comp[2].name;

                branchCompFirst.Text = comp[0].branch;
                branchCompSecond.Text = comp[1].branch;
                branchCompThird.Text = comp[2].branch;

                wareCompFirst.Text = comp[0].ware;
                wareCompSecond.Text = comp[1].ware;
                wareCompThird.Text = comp[2].ware;

                int countInnov = context.InformationAboutInnovations.Count();
                int countStrateg = context.InformationAboutInnovations.Count(p => p.Expr6 == "стратегический");
                int countLocal = context.InformationAboutInnovations.Count(p => p.Expr6 == "локальный");
                int countSys = context.InformationAboutInnovations.Count(p => p.Expr6 == "системный");

                countInnovLabel.Content = countInnov.ToString();
                strategCount.Content = countStrateg.ToString();
                localCount.Content = countLocal.ToString();
                systCount.Content = countSys.ToString();

                int countRealiz = context.realizations.Where(p => p.implementationState == "инновационный").Count();
                realiz.Content = "В реализации находится: " + countRealiz + " инновационных продуктов";

                int countInvest = context.realizations.Where(p => p.implementationState == "инновационный").Count();
                invest.Content = "В инвестиционной стадии находится: " + countInvest + " инновационных продуктов";


                int countPInvest = context.realizations.Where(p => p.implementationState == "инновационный").Count();
                invest.Content = "В прединвестиционной стадии находится: " + countPInvest + " инновационных продуктов";

            }
            catch(Exception ex)
            {
                MessageBox.Show("Скорее всего нет соединения с базой данных. Проверьте соединение. Приложение будет закрыто.", "Ошибка",
                                MessageBoxButton.OK, MessageBoxImage.Error);
                Application.Current.Shutdown();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MoreAboutCompanies macWindow = new MoreAboutCompanies();
            macWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddCompanyWindow addCompanyWindow = new AddCompanyWindow();
            addCompanyWindow.Show();
        }

        private void buttonMoreAboutInnovation_Click(object sender, RoutedEventArgs e)
        {
            MoreAboutInnovationWindow moreInnovWindow = new MoreAboutInnovationWindow();
            moreInnovWindow.Show();
        }

        private void buttonAddInnovation_Click(object sender, RoutedEventArgs e)
        {
            AddInnovationWindow addInnovationWindow = new AddInnovationWindow();
            addInnovationWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RealizationWindow realizWindow = new RealizationWindow();
            realizWindow.Show();
        }
    }
}
