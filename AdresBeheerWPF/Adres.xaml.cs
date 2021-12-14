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
    /// Interaction logic for AdresVerwijderen.xaml
    /// </summary>
    public partial class Adres : Window
    {
        public Adres()
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

        private void Toevoegen_Click(object sender, RoutedEventArgs e)
        {
            string var = textBox.Text;
            if (var == null)
            {
                MessageBox.Show("U voegt niets toe");
                ;
            }
            else
            {
                Adresbeheer_klassen.Adres adr = new Adresbeheer_klassen.Adres();
                AdressenBeheer a = new();
                a.VoegAdresToe(adr);
            }
        }

        private void btnVerwijderAdres_Click(object sender, RoutedEventArgs e)
        {
            string var = textBoxTwo.Text;
            int correctType = int.Parse(var);
            if (correctType <= 0)
            {
                MessageBox.Show("U verwijdert niets", "Textbox leeg", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                AdressenBeheer a = new();
                a.VerwijderAdres(correctType);
            }
        }

        private void btnBestaatAdres_Click(object sender, RoutedEventArgs e)
        {
            string var = textBox.Text;
            if (var == null)
            {
                MessageBox.Show("Dit is de informatietekst", "Uw input is leeg", MessageBoxButton.OK, MessageBoxImage.Error);
                ;
            }
            else
            {
                AdressenBeheer a = new();
                //a.BestaatAdres();
            }

        }

        private void btnUpdateAdres_Click(object sender, RoutedEventArgs e)
        {
        }


        private void btnHomeAdres_Click(object sender, RoutedEventArgs e)
        {
            WelcomeWindow wd = new();
            wd.Show();
            this.Close();
        }
    }
}
