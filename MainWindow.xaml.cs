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

            textentered = txtentered.Text.ToUpper();

            textentered = textentered.Replace(":-)", "I’m happy");
            textentered = textentered.Replace(":-(", "I’m unhappy");
            textentered = textentered.Replace(";-)", "Wink");
            textentered = textentered.Replace(":-P", "Stick out my tongue");
            textentered = textentered.Replace("(˜.˜)", "Sleepy");
            textentered = textentered.Replace("TA", "Totally Awesome");
            textentered = textentered.Replace("CCC", "Canadian Computing Competition");
            textentered = textentered.Replace("CUZ", "Because");
            textentered = textentered.Replace("TTYL", "Talk to you later");
            textentered = textentered.Replace("YW", "You’re Welcome");
            textentered = textentered.Replace("TY", "Thank You");
            textentered = textentered.Replace("CU", "See You");


            lblOutput.Content = textentered;
        }
    }
}
