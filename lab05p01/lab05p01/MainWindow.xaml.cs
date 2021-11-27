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

namespace lab05p01
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            if (int.TryParse(wartoscA.Text, out a)) ;
            else
            { a = 0;
                wartoscA.Text = "0";
            }
            if (int.TryParse(wartoscB.Text, out b)) ;
            else
            {
                b = 0;
                wartoscB.Text = "0";
            }
            if (int.TryParse(wartoscC.Text, out c));
            else
            {
                c = 0;
                wartoscC.Text = "0";
            }

          

        }
    }
}
