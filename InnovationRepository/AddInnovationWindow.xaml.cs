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
        public AddInnovationWindow()
        {
            InitializeComponent();
        }

        private void addContactBtn_Click(object sender, RoutedEventArgs e)
        {
            AddContact addContactWindow = new AddContact();
            addContactWindow.Show();
        }

        private void addInnovationBtn_Click(object sender, RoutedEventArgs e)
        {
            //expr1 = causeOf
            //expr2 = appArea
            //expr3 = chaMeetNeedsOf
            //expr4 = continyity 
            //expr5 = deegreNovelMark 
            //expr6 = expMaxShare 
            //expr7 = impactFactProd 
            //expr8 = impactToEconomy !!
            //expr9 = deegreNovelPot
            //expr10 = placeProdCycle
            //expr11 = impactProdProc
            //expr12 = Prevelency

            Classification myClassification = new Classification();
            
        }

 
    }
}
