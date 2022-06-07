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
    /// Interaction logic for KeuzeWindow_staticVariabele.xaml
    /// </summary>
    public partial class KeuzeWindow_staticVariabele : Window
    {
        public KeuzeWindow_staticVariabele()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (ckbUpper.IsChecked == true)
                Data.Tekst = Data.Tekst.ToUpper(); // Data.Tekst veranderen
            else
                Data.Tekst = Data.Tekst.ToLower(); // Data.Tekst veranderen
                                                   // KeuzeWindow verbergen zodat MainWindow terug actief wordt (Window_Activated).
                                                   // Daarna Data.Tekst in de MainWindow weer uitlezen
            Hide();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
