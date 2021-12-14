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

namespace AdresWPF
{
    /// <summary>
    /// Interaction logic for VergetenWachwoord.xaml
    /// </summary>
    public partial class VergetenWachwoord : Window
    {
        public VergetenWachwoord()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Logica voor nieuw account login
        /// </summary>
        private void buttonSchrijfIn_Click(object sender, RoutedEventArgs e)
        {
            string naam = textBoxNaam.Text;
            string leeftijd = textBoxLeeftijd.Text;
            string nationaliteit = textBoxNatio.Text;
            string geslacht = textBoxGeslacht.Text;
            string accountDetails = $"Accountgegevens\nNaam: {naam}\nLeeftijd: {leeftijd}\nNationaliteit: {nationaliteit}\n Geslacht: {geslacht}";
            if (string.IsNullOrEmpty(naam) && string.IsNullOrEmpty(leeftijd) && string.IsNullOrEmpty(nationaliteit)
                && string.IsNullOrEmpty(geslacht)){
                MessageBox.Show("Invoervelden waren leeg!");
            }
            else
            {
                MessageBox.Show(accountDetails);
                System.Threading.Thread.Sleep(3000);
                MessageBox.Show($"Welkom {naam}");
                System.Threading.Thread.Sleep(2000);
                Login l = new();
                l.Show();
                this.Close();
            }
        }
        /// <summary>
        /// Reset password proces
        /// </summary>
        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Er werd een link verstuuurd!");
        }
    }
}
