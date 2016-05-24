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
    /// Interaction logic for AddInnovationWindow.xaml
    /// </summary>
    public partial class AddInnovationWindow : Window
    {
        Entities context = new Entities();
 

        public AddInnovationWindow()
        {
            InitializeComponent();
            LoadInfo();
        }

        void LoadInfo()
        {
            try
            {
                var authors = context.contacts.ToList();
                foreach (var author in authors)
                {
                    authorBox.Items.Add("[" + author.ID_contact + "] " + author.name + " " + author.surname);
                    ownerBox.Items.Add("[" + author.ID_contact + "] " + author.name + " " + author.surname);
                }
                var states = context.StatesInnovations.ToList();
                foreach (var state in states)
                    stateBox.Items.Add(state.stateInnvoation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Скорее всего нет соединения с базой данных. Проверьте соединение. Приложение будет закрыто.", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
                Application.Current.Shutdown();
            }

        }

        private void addContactBtn_Click(object sender, RoutedEventArgs e)
        {
            AddContact addContactWindow = new AddContact();
            addContactWindow.Show();
        }


        Classification myClassification = new Classification();

        //expr1 = causeOf
        //expr2 = appArea
        //expr3 = chaMeetNeedsOf
        //expr4 = continyity 
        //expr5 = deegreNovelMark 
        //expr6 = expMaxShare 
        //expr7 = impactFactProd 
        //expr8 = impactToEconomy 
        //expr9 = deegreNovelPot
        //expr10 = placeProdCycle
        //expr11 = impactProdProc
        //expr12 = Prevelency

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            int selectedId = context.causeOfs.Where(p => p.name == pressed.Content.ToString()).FirstOrDefault().ID_causeOf;
            myClassification.ID_causeOf = selectedId;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            int selectedId = context.appAreas.Where(p => p.name == pressed.Content.ToString()).FirstOrDefault().ID_appArea;
            myClassification.ID_appArea = selectedId;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            int selectedId = context.chaMeetNeedsOfs.Where(p => p.name == pressed.Content.ToString()).FirstOrDefault().ID_chaMeetNeedsOf;
            myClassification.ID_chaMeetNeedsOf = selectedId;
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            int selectedId = context.Prevelencies.Where(p => p.name == pressed.Content.ToString()).FirstOrDefault().ID_prevelency;
            myClassification.ID_prevelency = selectedId;
        }

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            int selectedId = context.expMarShares.Where(p => p.name == pressed.Content.ToString()).FirstOrDefault().ID_expMarShare;
            myClassification.ID_expMarShare = selectedId;
        }

        private void RadioButton_Checked_6(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            int selectedId = context.continuities.Where(p => p.name == pressed.Content.ToString()).FirstOrDefault().ID_continuity;
            myClassification.ID_continuity = selectedId;
        }

        private void RadioButton_Checked_7(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            int selectedId = context.impactFactProds.Where(p => p.name == pressed.Content.ToString()).FirstOrDefault().ID_impactFactProd;
            myClassification.ID_impactFactProd = selectedId;
        }

        private void RadioButton_Checked_8(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            int selectedId = context.imactToEconomies.Where(p => p.name == pressed.Content.ToString()).FirstOrDefault().ID_imactToEconomy;
            myClassification.ID_imactToEconomy = selectedId;
        }

        private void RadioButton_Checked_9(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            int selectedId = context.degreeNovelPots.Where(p => p.name == pressed.Content.ToString()).FirstOrDefault().ID_degreeNovelPot;
            myClassification.ID_degreeNovelPot = selectedId;
        }

        private void RadioButton_Checked_10(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            int selectedId = context.placeProdCycles.Where(p => p.name == pressed.Content.ToString()).FirstOrDefault().ID_placeProdCycle;
            myClassification.ID_placeProdCycle = selectedId;
        }

        private void RadioButton_Checked_11(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            int selectedId = context.impactProdProcs.Where(p => p.name == pressed.Content.ToString()).FirstOrDefault().ID_impactProdProc;
            myClassification.ID_impactProdProc = selectedId;
        }

        private void RadioButton_Checked_12(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            int selectedId = context.degreeNovelMarks.Where(p => p.name == pressed.Content.ToString()).FirstOrDefault().ID_degreeNovelMark;
            myClassification.ID_degreeNovelMark = selectedId;
        }



        private void addInnovationBtn_Click(object sender, RoutedEventArgs e)
        {
            string x = authorBox.Text.ToString();
            string[] s = x.Split(']');
            s[0] = s[0].Replace('[', '0');
            int authorId = Convert.ToInt32(s[0]);

            string x1 = ownerBox.Text.ToString();
            string[] s1 = x1.Split(']');
            s1[0] = s1[0].Replace('[', '0');
            int ownerId = Convert.ToInt32(s1[0]);

            context.Classifications.Add(myClassification);
            context.SaveChanges();
          

            int addedClassification = context.Classifications.Take(10000).AsEnumerable().Last().ID_classification;
            Innovation myInnovation = new Innovation();
            myInnovation.Name = nameBox.Text.ToString();
            myInnovation.ID_innovWorksheet = 1;
            myInnovation.ID_classification = addedClassification;

            TextRange range = new TextRange(descriptionBox.Document.ContentStart, descriptionBox.Document.ContentEnd);
            myInnovation.description = range.Text;
            myInnovation.ID_contactAuthor = authorId;
            myInnovation.ID_contactOwner = ownerId;

            int idState = context.StatesInnovations.Where(p => p.stateInnvoation == stateBox.Text.ToString()).FirstOrDefault().ID_stateInnov;
            myInnovation.ID_stateInnov = idState;

            context.Innovations.Add(myInnovation);
            context.SaveChanges();
            MessageBox.Show("Инновационный продукт успешно добавлен");
            this.Close();
        }

    }
}
