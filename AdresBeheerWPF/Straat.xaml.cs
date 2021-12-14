using Adresbeheer_klassen;
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

namespace AdresBeheerWPF
{
    /// <summary>
    /// Interaction logic for AdresControleren.xaml
    /// </summary>
    public partial class Straat : Window
    {
        public Straat()
        {
            InitializeComponent();
        }

        private void StraatToevoegen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StraatVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            string delete = textBoxTwo.Text;
            int correctDelete = int.Parse(delete);
            if (correctDelete <= 0)
            {
                MessageBox.Show("U verwijdert niets");
            }
            else
            {
                AdressenBeheer adr = new();
                adr.VerwijderStraat(correctDelete);
            }
        }

        private void BestaatStraat_Click(object sender, RoutedEventArgs e)
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
