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
    /// Interaction logic for InnovationWindow.xaml
    /// </summary>
    public partial class InnovationWindow : Window
    {
        Entities context = new Entities();

        public InnovationWindow()
        {
            InitializeComponent();
            LoadInfo();
        }


        void LoadInfo()
        {
            var innovationInfo = context.InformationAboutInnovations.Where(p => p.ID_innovation == MyCompany.selectedInnovation).FirstOrDefault();
            nameInnovation.Text = innovationInfo.Name.ToString().ToUpper();
            Expr1.Text = "По причине возникновения: " + innovationInfo.Expr1.ToString().ToUpper();
            Expr2.Text = "По области применения: " + innovationInfo.Expr2.ToString().ToUpper();
            Expr3.Text = "По характеру удовлетворяемых потребностей: " + innovationInfo.Expr3.ToString().ToUpper();
            Expr4.Text = "По преемственности: " + innovationInfo.Expr4.ToString().ToUpper();
            Expr5.Text = "По степени новизны для рынка: " + innovationInfo.Expr5.ToString().ToUpper();
            Expr6.Text = "По ожидаемому охвату доли рынка: " + innovationInfo.Expr6.ToString().ToUpper();
            Expr7.Text = "По уровню воздействия на факторы производства: " + innovationInfo.Expr7.ToString().ToUpper();
            Expr8.Text = "По уровню воздействия на экономику: " + innovationInfo.Expr8.ToString().ToUpper();
            Expr9.Text = "По степени новизны и инновационному потенциалу: " + innovationInfo.Expr9.ToString().ToUpper();
            Expr10.Text = "По месту в производственном цикле: " + innovationInfo.Expr10.ToString().ToUpper();
            Expr11.Text = "По уровню воздействия на процесс производства: " + innovationInfo.Expr11.ToString().ToUpper();
            Expr12.Text = "По распространенности: " + innovationInfo.Expr12.ToString().ToUpper();

            int idAuthor = innovationInfo.ID_contactAuthor;
            int idOwner = innovationInfo.ID_contactOwner;

            var author = context.contacts.Where(p => p.ID_contact == idAuthor).FirstOrDefault();
            var owner = context.contacts.Where(p => p.ID_contact == idOwner).FirstOrDefault();

            dName.Text = author.name.ToString() + " " + author.surname.ToString();
            if (author.telephone != null)
                dtelephone.Text = "Телефон: " + author.telephone.ToString();
            if(author.email != null)
                demail.Text = "Email: " + author.email.ToString();

            oName.Text = author.name.ToString() + " " + owner.surname.ToString();
            if (owner.telephone != null)
                otelephone.Text = "Телефон: " + owner.telephone.ToString();
            if (owner.email != null)
                oemail.Text = "Email: " + owner.email.ToString();

        }
    }
}
