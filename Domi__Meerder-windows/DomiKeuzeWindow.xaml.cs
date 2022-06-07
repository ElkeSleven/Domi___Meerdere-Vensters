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
    /// Interaction logic for DomiKeuzeWindow.xaml
    /// </summary>
    public partial class DomiKeuzeWindow : Window
    {
        //** 
        private TextBox tb;

        public DomiKeuzeWindow(TextBox text)
        {
            InitializeComponent();

            tb = text; // De 2 objecten worden aan elkaar gekoppeld.

        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (ckbUpper.IsChecked == true)
                tb.Text = tb.Text.ToUpper();
            else
                tb.Text = tb.Text.ToLower();

            DialogResult = true; // Doorgeven op OK geklikt.
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

            DialogResult = false; // Doorgeven op CANCEL geklikt.

        }
    }
}
