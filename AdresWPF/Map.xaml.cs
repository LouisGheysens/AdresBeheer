using System;
using System.Windows;
using Microsoft.Web.WebView2.Core;

namespace AdresWPF
{
    /// <summary>
    /// Interaction logic for TestMaps.xaml
    /// </summary>
    public partial class Map : Window
    {
        /// <summary>
        /// Constructor maps
        /// </summary>
        public Map()
        {
            InitializeComponent();
            webView.NavigationStarting += EnsureHttps;
            InitializeAsync();
        }

        /// <summary>
        /// Webview2 initialiseren voor beter webgebruik
        /// </summary>
        async void InitializeAsync()
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.WebMessageReceived += UpdateAddressBar;

            await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");
            await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.addEventListener(\'message\', event => alert(event.data));");
        }

        /// <summary>
        /// Uodate van de adressenbalk aan de hand van een core
        /// </summary>
        void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String uri = args.TryGetWebMessageAsString();
            addressBar.Text = uri;
            webView.CoreWebView2.PostWebMessageAsString(uri);
        }
        /// <summary>
        /// Retourneren naar de home pagina
        /// </summary>
        private void ButtonGo_Click(object sender, RoutedEventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                //webView.CoreWebView2.Navigate(addressBar.Text);
                MainWindow m = new();
                m.Show();
                this.Close();
            }
        }

        /// <summary>
        /// Https check uitvoeren
        /// </summary>
        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            String uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                webView.CoreWebView2.ExecuteScriptAsync($"alert('{uri} is not safe, try an https link')");
                args.Cancel = true;
            }
        }
    }
}
