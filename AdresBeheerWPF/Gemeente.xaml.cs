using Adresbeheer_klassen;
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
using System.Windows.Threading;

namespace AdresBeheerWPF
{
    /// <summary>
    /// Interaction logic for AdresSelecteren.xaml
    /// </summary>
    public partial class Gemeente : Window
    {
        public Gemeente()
        {
            InitializeComponent();
        }
        private void _Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, (DispatcherOperationCallback)delegate (object o)
            {
                ((Window)sender).Hide();
                return null;
            }, null);
            e.Cancel = true;
        }

        private void btnvoegGemeenteToe_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnBestaatGemeente(object sender, RoutedEventArgs e)
        {

        }

        private void btnVerwijderGemeente(object sender, RoutedEventArgs e)
        {
            string element = textBoxTwo.Text;
            int correctElement = int.Parse(element);
            if (correctElement <= 0)
            {
                MessageBox.Show("U verwijdert niets");
            }
            else
            {
                AdressenBeheer g = new();
                g.VerwijderGemeente(correctElement);

            }
        }

        private void btnHomeAdres_Click(object sender, RoutedEventArgs e)
        {
            WelcomeWindow wd = new();
            wd.Show();
            this.Close();
        }
    }
}
