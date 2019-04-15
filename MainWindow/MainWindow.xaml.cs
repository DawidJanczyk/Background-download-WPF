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
using System.Net;
using Microsoft.Win32;
using System.Diagnostics;

namespace Backgrounds_app
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ButtonDownload1_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://i.imgur.com/REM4kQU.jpg", @"C:/Pobrane/city.jpg");
            Process.Start("C:/Pobrane/city.jpg");
        }
        private void ButtonDownload2_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("http://bighdwalls.com/wp-content/uploads/fulton-st-New-York-View-HD-Wallpaper.jpg", @"C:/Pobrane/NYC.jpg");
            Process.Start("C:/Pobrane/NYC.jpg");
        }
        private void ButtonDownload3_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://images6.alphacoders.com/414/414179.jpg", @"Desktop/Pobrane/tiger.jpg");
            Process.Start("C:/Pobrane/tiger.jpg");
        }
        private void ButtonDownload4_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://wallpapercave.com/wp/wp3277757.jpg", @"C:/Pobrane/rickmorty.jpg");
            Process.Start("C:/Pobrane/rickmorty.jpg");
        }
        private void ButtonDownload5_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://wallpapersultra.net/wp-content/uploads/4K-Desktop-Background-HD-3840%C3%972160.jpg", @"C:/Pobrane/mountain.jpg");
            Process.Start("C:/Pobrane/mountain.jpg");
        }
        private void ButtonDownload6_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://pixelz.cc/wp-content/uploads/2018/09/mac-osx-10.13-high-sierra-background-uhd-4k-wallpaper.jpg", @"C:/Pobrane/macos.jpg");
            Process.Start("C:/Pobrane/macos.jpg");
        }
        private void ButtonDownload7_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://i.imgur.com/tUvlwvB.jpg", @"C:/Pobrane/dark.jpg");
            Process.Start("C:/Pobrane/dark.jpg");
        }
        private void ButtonDownload8_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://wallpapermemory.com/uploads/666/london-background-hd-4k-484784.jpg", @"C:/Pobrane/london.jpg");
            Process.Start("C:/Pobrane/london.jpg");
        }
    }
}
