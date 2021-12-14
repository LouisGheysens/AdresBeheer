using System;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Adresbeheer_klassen;
using Microsoft.Data.SqlClient;

namespace AdresWPF
{
    /// <summary>
    /// Interaction logic for Gemeente.xaml
    /// </summary>
    public partial class GemeenteWindow : Window
    {
        public GemeenteWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }

        /// <summary>
        /// Overerving klas
        /// </summary>
        AdressenBeheer _adresBeheer = new();

        /// <summary>
        /// Gemeente toevoegen
        /// </summary>

        private void VoegGemeente_Click(object sender, RoutedEventArgs e)
        {
            Gemeente gem = new(textBoxNISCODE.Text, textBoxGemeentenaam.Text);
            try
            {
                _adresBeheer.VoegGemeenteToe(gem); ;
                MessageBox.Show("Gemeente toegevoegd");
            }
            catch (Exception el)
            {
                { MessageBox.Show("Deze gemeente werd niet toegevoegd!", "toevoeging gemeente gefaald", MessageBoxButton.OK, MessageBoxImage.Information); }
            }
        }

        /// <summary>
        /// Gemeente verwijderen
        /// </summary>
        private void VerwijderGemeente_Click(object sender, RoutedEventArgs e)
        {
            int niscode = int.Parse(textBoxNISCODE.Text);

            if (niscode <= 0)
            {
                MessageBox.Show("Niscode is ongeldig");
            }
            try
            {
                _adresBeheer.VerwijderGemeente(niscode);
                MessageBox.Show("Niscode werd verwijderd");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Bestaan gemeente genereren
        /// </summary>
        private void BestaatGemeente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_adresBeheer.BestaatGemeente(textBoxGemeentenaam.Text, int.Parse(textBoxNISCODE.Text))) { MessageBox.Show("Deze gemeente bestaat!", "Bestaat gemeente", MessageBoxButton.OK, MessageBoxImage.Information); }
                else { MessageBox.Show("Deze gemeente bestaat niet!", "Bestaat gemeente", MessageBoxButton.OK, MessageBoxImage.Information); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error straat!", MessageBoxButton.OK, MessageBoxImage.Error); }
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
        /// Gemeente updaten
        /// </summary>
        private void UpdateGemeente_Click(object sender, RoutedEventArgs e)
        {
            Gemeente gey = new Gemeente(textBoxNISCODE.Text, textBoxGemeentenaam.Text);
            try
            {
                _adresBeheer.UpdateGemeente(gey); ;
                MessageBox.Show("Gemeente updated");
            }
            catch (Exception el)
            {
                { MessageBox.Show("Deze gemeente werd niet updated!", "updated gemeente gefaald", MessageBoxButton.OK, MessageBoxImage.Information); }
            }
        }
        

        /// <summary>
        /// Lijst gemeente
        /// </summary>
        private void load_Gemeente()
        {
            _adresBeheer.SelecteerGemeenten().ForEach(e => cboG.Items.Add($"{e.NIScode} - {e.Naam}"));
        }
        /// <summary>
        /// Automatische kern lijst
        /// </summary>
        private void cboG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(cboG.SelectedItem.ToString(), "Gemeente",MessageBoxButton.OK,MessageBoxImage.Information);
        }
        /// <summary>
        /// Window loaded event
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _adresBeheer.SelecteerGemeenten().ForEach(e => cboG.Items.Add($"{e.NIScode} - {e.Naam}"));
        }
    }
}
