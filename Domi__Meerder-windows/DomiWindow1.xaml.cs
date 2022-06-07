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


        #region Data uitwisselen tussen verschillende Windows
        
        #region Doorgeven via constructor
        private void btnHoofdKleineLetters_Click(object sender, RoutedEventArgs e)
        {
            KeuzeWindow_viaConstructor keuzeWindow = new KeuzeWindow_viaConstructor(txtHoofdKleineLetters); // geef TextBox van MainWindow door aan KeuzeWindow
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
        #endregion


        #region Opslaan als static variabele in static class en daarna terug uitlezen
        /* zo maak je een class aan: 
         * Rechterklik op je project (niet de Solution!) 
         * Add > Class...
         * Maak een nieuwe class aan (bijvoorbeeld Data.cs)
         * Maak de class public en static 
         * declareer een public static variable 
         */

       
        private void btnViaStaticClass_Click(object sender, RoutedEventArgs e)
        {
            Data.Tekst = txtViaStaticClass.Text;  //Inhoud van TxtResultaat toekennen aan klasse Data.

            KeuzeWindow_staticVariabele keuzeWindow = new KeuzeWindow_staticVariabele();
            keuzeWindow.Show();
        }
        
        //MainWindow opnieuw actief => terug kopieren
        private void Window_Activated(object sender, EventArgs e)
        {
            //MainWindow opnieuw actief => terug kopieren
            txtViaStaticClass.Text = Data.Tekst;
        }
        #endregion
        #endregion
    }
}
