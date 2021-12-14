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
using Adresbeheer_klassen;
using System.Data;
using Microsoft.Data.SqlClient;

namespace AdresWPF
{
    /// <summary>
    /// Interaction logic for Adres.xaml
    /// </summary>
    public partial class AdresWindow : Window
    {
        public AdresWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }


        /// <summary>
        /// Overerving klas
        /// </summary>
        AdressenBeheer _adresBeheer = new();

        /// <summary>
        /// Adres toevoegen
        /// </summary>
        private void VoegAdresToe_Click(object sender, RoutedEventArgs e)
        {
            Adres a = new(textBoxID.Text, textBoxStraatID.Text, textBoxLocatieHuisnummer.Text, textBoxAppnummer.Text, textBoxBusnummer.Text, textBoxLocatieHuisnummerlabel.Text,
                textBoxLocatieID.Text, textBoxPostcode.Text);
            try
            {
                _adresBeheer.VoegAdresToe(a); ;
                MessageBox.Show("Adres toegevoegd");
            }
            catch (Exception el)
            {
                { MessageBox.Show("Dit adres werd niet toegevoegd!", "toevoeging adres gefaald", MessageBoxButton.OK, MessageBoxImage.Information); }
            }
        }
        /// <summary>
        /// Adres verwijderen
        /// </summary>
        private void VerwijderAdres_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxID.Text != null)
            {
                int id = int.Parse(textBoxID.Text);

                try
                {
                    _adresBeheer.VerwijderAdres(id);
                    MessageBox.Show("Id werd verwijderd");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
        }
        /// <summary>
        /// Bestaan adres genereren
        /// </summary>
        private void BestaatAdres_Click(object sender, RoutedEventArgs e)
        {
            Adres a = new Adres(textBoxID.Text, textBoxStraatID.Text, textBoxLocatieHuisnummer.Text, textBoxBusnummer.Text, textBoxAppnummer.Text, textBoxLocatieHuisnummerlabel.Text,
                textBoxPostcode.Text, textBoxLocatieID.Text);
            try
            {
                if (_adresBeheer.BestaatAdres(a)) { MessageBox.Show("dit adres straat bestaat!", "Bestaat adress", MessageBoxButton.OK, MessageBoxImage.Information); }
                else { MessageBox.Show("dit adres bestaat niet!", "Bestaat adres", MessageBoxButton.OK, MessageBoxImage.Information); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error adres!", MessageBoxButton.OK, MessageBoxImage.Error); }
        }
        /// <summary>
        /// Turn back button
        /// </summary>
        private void KeerTerugNaarMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new();
            w.Show();
            this.Close();
        }
        /// <summary>
        /// Adres updaten
        /// </summary>
        private void UpdateAdres_Click(object sender, RoutedEventArgs e)
        {
            Adres adr = new Adres(textBoxID.Text, textBoxStraatID.Text, textBoxLocatieHuisnummer.Text, textBoxBusnummer.Text, textBoxAppnummer.Text, textBoxLocatieHuisnummerlabel.Text,
                textBoxPostcode.Text, textBoxLocatieID.Text);
            try
            {
                _adresBeheer.UpdateAdres(adr); ;
                MessageBox.Show("Adres upgedated");
            }
            catch (Exception el)
            {
                { MessageBox.Show("Dit adres werd niet geupadated!", "update adres gefaald", MessageBoxButton.OK, MessageBoxImage.Information); }
            }
        }
    }
}
