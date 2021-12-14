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

namespace AdresBeheerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class WelcomeWindow : Window
    {
        public WelcomeWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Navigatie aan de hand van buttons
        /// </summary>

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void NaarAdres_Click(object sender, RoutedEventArgs e)
        {
            Adres a = new();
            a.Show();
            this.Close();
        }

        private void NaarStraat_Click(object sender, RoutedEventArgs e)
        {
            Straat s = new();
            s.Show();
            this.Close();
        }

        private void NaarGemeente_Click(object sender, RoutedEventArgs e)
        {
            Gemeente g = new();
            g.Show();
            this.Close();
        }

        private void NaarLocatie_Click(object sender, RoutedEventArgs e)
        {
            Adreslocatie ad = new();
            ad.Show();
            this.Close();
        }
    }
}
