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

namespace AdresWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }
        /// <summary>
        /// Navigatie adres
        /// </summary>
        private void NaarAdres_Click(object sender, RoutedEventArgs e)
        {
            AdresWindow a = new();
            a.Show();
            this.Close();
        }
        /// <summary>
        /// Navigatie straat
        /// </summary>
        private void NaarStraat_Click(object sender, RoutedEventArgs e)
        {
            StraatWindow s = new();
            s.Show();
            this.Close();
        }
        /// <summary>
        /// Navigatie gemeente
        /// </summary>
        private void NaarGemeente_Click(object sender, RoutedEventArgs e)
        {
            GemeenteWindow g = new();
            g.Show();
            this.Close();
        }
        /// <summary>
        /// Navigatie maps
        /// </summary>
        private void NaaropzoekData_Click(object sender, RoutedEventArgs e)
        {
            Map m = new();
            m.Show();
            this.Close();
        }
        /// <summary>
        /// Navigatie loguit
        /// </summary>
        private void logUit_Click(object sender, RoutedEventArgs e)
        {
            Login l = new();
            l.Show();
            this.Close();
        }
    }
}
