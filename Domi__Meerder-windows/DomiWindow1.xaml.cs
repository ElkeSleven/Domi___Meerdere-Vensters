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

namespace Domi__Meerder_windows
{
    /// <summary>
    /// Interaction logic for DomiWindow1.xaml
    /// </summary>
    public partial class DomiWindow1 : Window
    {
        public DomiWindow1()
        {
            InitializeComponent();
        }


        #region verschil tussen .Show en .ShowDialog
        //**opent ander window *_Gebruiker kan wisselen tussen bijde windows 
        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            DomiWindow2 w2 = new DomiWindow2();
            w2.Show();
        }
        //**opent ander window *_Gebruiker kan niet terug naar vorig window  
        private void BtnShowDialog_Click(object sender, RoutedEventArgs e)
        {
            DomiWindow2 w2 = new DomiWindow2();
            w2.ShowDialog();
        }




        #endregion

        private void btnHoofdKleineLetters_Click(object sender, RoutedEventArgs e)
        {
            DomiKeuzeWindow keuzeWindow = new DomiKeuzeWindow(txtHoofdKleineLetters); // geef TextBox van MainWindow door aan KeuzeWindow
                                                                     // Modaal venster oproepen
            keuzeWindow.ShowDialog();
            // Opvangen op welke knop bij het KeuzeWindow geklikt is.
            if (keuzeWindow.DialogResult == true)
            {
                MessageBox.Show("Knop Ok gedrukt.");
            }
            else
            {
                MessageBox.Show("Knop Cancel/Sluiten gedrukt.");
            }
        }
    }
}
