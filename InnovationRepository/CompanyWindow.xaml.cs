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
    /// Interaction logic for CompanyWindow.xaml
    /// </summary>
    public partial class CompanyWindow : Window
    {
        Entities context = new Entities();
        public CompanyWindow()
        {
            InitializeComponent();
            LoadCompanyInformation();
        }

        void LoadCompanyInformation()
        {
            var company = context.InformationAboutCompanies.Where(p=> p.ID_company == MyCompany.selectedCompany).First();
            if (company != null)
            {
                nameCompany.Text = company.name.ToString();
                branch.Text = company.branch.ToString();
                district.Text = "Область: " + company.district.ToString();
                town.Text = "Город: " + company.town.ToString();
                street.Text = "Улица: " + company.street.ToString();
                house.Text = "Дом: " + company.house.ToString();
                flat.Text = "Квартира/Блок: " + company.flat.ToString();
                ware.Text = company.ware.ToString();
                name.Text = company.uname.ToString() + " " + company.secondName + " " + company.surname.ToString();
                email.Text = "Email: " + company.email;
                telephone.Text = "Telephone: " + company.telephone;
            }
            //MessageBox.Show(MyCompany.selectedCompany.ToString());
        }
    }
}
