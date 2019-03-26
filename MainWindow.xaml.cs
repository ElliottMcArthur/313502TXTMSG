/* Elliott McArthur
 * 313502
 * Tuesday, March 26, 2019
 * Translate text messages to their meaning
*/
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

namespace _313502TXTMSG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Background = Brushes.Aqua;
        }

        private void btntranslate_Click(object sender, RoutedEventArgs e)
        {
            string textentered = txtentered.Text;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }

            textentered = txtentered.Text.ToUpper();

            textentered = textentered.Replace(":-)", "I’m happy" + Environment.NewLine);
            textentered = textentered.Replace(":-(", "I’m unhappy" + Environment.NewLine);
            textentered = textentered.Replace(";-)", "Wink" + Environment.NewLine);
            textentered = textentered.Replace(":-P", "stick out my tongue" + Environment.NewLine);
            textentered = textentered.Replace("(˜.˜)", "Sleepy" + Environment.NewLine);
            textentered = textentered.Replace("TA", "Totally Awesome" + Environment.NewLine);
            textentered = textentered.Replace("CCC", "Canadian Computing Competition" + Environment.NewLine);
            textentered = textentered.Replace("CUZ", "because" + Environment.NewLine);
            textentered = textentered.Replace("TTYL", "Talk to you later" + Environment.NewLine);
            textentered = textentered.Replace("YW", "You’re Welcome" + Environment.NewLine);
            textentered = textentered.Replace("TY", "Thank You" + Environment.NewLine);


            lblOutput.Content = " " + textentered;
        }
    }
}
