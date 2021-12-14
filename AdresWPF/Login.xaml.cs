using System;
using System.Text;
using System.Windows;

namespace AdresWPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }
        /// <summary>
        /// Login go-further button
        /// </summary>
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new();
            m.Show();
            this.Close();
        }
        /// <summary>
        /// Wachtwoord vergeten
        /// </summary>
        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            VergetenWachwoord vw = new();
            vw.Show();
            this.Close();
        }
        /// <summary>
        /// Wachtwoord vergeten
        /// </summary>
        private void buttonGoAccount_Click(object sender, RoutedEventArgs e)
        {
            VergetenWachwoord v = new();
            v.Show();
            this.Close();
        }
    }
}
