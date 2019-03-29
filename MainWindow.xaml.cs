/* Elliott McArthur
 * 313502
 * 3/28/2019
 * Outputting different time zones
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

namespace _313502GOODTIMES
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Background = Brushes.Green;
        }

        private void btntime_Click(object sender, RoutedEventArgs e)
        {
            string time = txtinput.Text;
            int.TryParse(time, out int Ottawatime);

            int Victoria = Ottawatime - 300;
            int Edmonton = Ottawatime - 200;
            int Winnipeg = Ottawatime - 100;
            int Toronto = Ottawatime;
            int Halifax = Ottawatime + 100;
            int StJohns = Ottawatime + 130;

            if(Victoria <= 0)
            {
                Victoria = Victoria += 2400;
            }
            if (Victoria % 100 > 59) Victoria = Victoria - 60 + 100;

            if(Edmonton <= 0)
            {
                Edmonton = Edmonton + 2400;
            }
            if (Edmonton % 100 > 59) Edmonton = Edmonton - 60 + 100;

            if (Winnipeg <= 0)
            {
                Winnipeg = Winnipeg + 2400;
            }
            if (Winnipeg % 100 > 59) Winnipeg = Winnipeg - 60 + 100;

            if (Toronto % 100 > 59) Toronto = Toronto - 60 + 100;

            if(Halifax >= 2400)
            {
                Halifax = Halifax -= 2400;
            }
            if (Halifax % 100 > 59) Halifax = Halifax - 60 + 100;

            if (StJohns >= 2459)
            {
                StJohns = StJohns -= 2400;
            }
            if (StJohns % 100 > 59) StJohns = StJohns - 60 + 100;

            lblOutput.Content = "The time in Victoria is " + Victoria.ToString() + Environment.NewLine + "The time in Edmonton is " + Edmonton.ToString() + Environment.NewLine + "The time in Winnipeg is " + Edmonton.ToString() + Environment.NewLine + "The time in Toronto is " + Toronto.ToString() + Environment.NewLine + "The time in Halifax is " + Halifax.ToString() + Environment.NewLine + "The time is St Johns is " + StJohns.ToString() + Environment.NewLine;
        }
    }
}
