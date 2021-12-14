using System;
using System.Windows;
using System.Windows.Input;
using Adresbeheer_klassen;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace AdresWPF
{
    /// <summary>
    /// Interaction logic for Straat.xaml
    /// </summary>
    public partial class StraatWindow : Window
    {
        /// <summary>
        /// Consturctor straat
        /// </summary>
        public StraatWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }

        /// <summary>
        /// Overerving klas
        /// </summary>
        AdressenBeheer _adresBeheer = new();

        /// <summary>
        /// straat verwijderen
        /// </summary>
        private void VerwijderStraat_Click(object sender, RoutedEventArgs e)
        {
            if(textBoxStraatWindowID.Text != null)
            {
                int id = int.Parse(textBoxStraatWindowID.Text);

                try
                {
                    _adresBeheer.VerwijderStraat(id);
                    MessageBox.Show("Id werd verwijderd");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }
        /// <summary>
        /// Betsaan straat genereren
        /// </summary>
        private void BestaatStraat_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               if(_adresBeheer.BestaatStraatnaam(textBoxStraatnaam.Text, int.Parse(textBoxStraatWindowNISCODE.Text))) { MessageBox.Show("Deze straat bestaat!", "Bestaat straat", MessageBoxButton.OK, MessageBoxImage.Information); }
               else { MessageBox.Show("Deze straat bestaat niet!", "Bestaat straat", MessageBoxButton.OK, MessageBoxImage.Information); }
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
            Close();
        }
        /// <summary>
        /// Straat updaten
        /// </summary>
        private void UpdateStraat_Click(object sender, RoutedEventArgs e)
        {
            Straat straat = new Straat(textBoxStraatWindowID.Text, textBoxStraatnaam.Text, textBoxStraatWindowNISCODE.Text);
            try
            {
                _adresBeheer.UpdateStraat(straat); ;
                MessageBox.Show("Straat updated");
            }
            catch (Exception el)
            {
                { MessageBox.Show("Deze straat werd niet geupdated!", "update straat gefaald", MessageBoxButton.OK, MessageBoxImage.Information); }
            }
        }
        /// <summary>
        /// Text check met regex
        /// </summary>
        private void textBoxStraatWindowID_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex r = new Regex("[^0-9]+");
            e.Handled = r.IsMatch(e.Text);
        }
        /// <summary>
        /// straat toevoegen
        /// </summary>
        private void VoegStraatToe(object sender, RoutedEventArgs e)
        {
            Straat straat = new Straat(textBoxStraatWindowID.Text, textBoxStraatnaam.Text, textBoxStraatWindowNISCODE.Text);
            try
            {
                _adresBeheer.VoegStraatToe(straat); ;
                MessageBox.Show("Straat toegevoegd");
            }
            catch (Exception el)
            {
                { MessageBox.Show("Deze straat werd niet toegevoegd!", "toevoeging straat gefaald", MessageBoxButton.OK, MessageBoxImage.Information); }
            }
        }

        /// <summary>
        /// PUUR TESTING
        /// </summary>

        //private void loadStraten()
        //{
        //    _adresBeheer.SelecteerStraten().ForEach(e => comboBox.Items.Add($"{e.Id} - {e.Naam} - {e.NISCODE}"));
        //}

        //private void comboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        //{
        //    MessageBox.Show(comboBox.SelectedItem.ToString(), "straat", MessageBoxButton.OK, MessageBoxImage.Information);
        //}

        //private void Window_Loaded(object sender, RoutedEventArgs args)
        //{
        //    _adresBeheer.SelecteerStraten().ForEach((e => comboBox.Items.Add($"{e.Id} - {e.Naam} - {e.NISCODE}")));
        //}
    }
}
