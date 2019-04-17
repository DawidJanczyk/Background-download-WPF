using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
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

namespace Backgrounds_app
{
    /// <summary>
    /// Logika interakcji dla klasy Cartoon.xaml
    /// </summary>
    public partial class Cartoon : Window
    {
        public Cartoon()
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
            client.DownloadFile("http://www.meliesblogs.com.br/melies/wp-content/uploads/2015/04/minions_2015-1920x1080.jpg", @"C:/Pobrane/minions.jpg");
            Process.Start("C:/Pobrane/minions.jpg");
        }
        private void ButtonDownload2_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://cdn.allwallpaper.in/wallpapers/1920x1080/16855/cartoon-network-sunset-nature-houses-adventure-time-1920x1080-wallpaper.jpg", @"C:/Pobrane/adventure.jpg");
            Process.Start("C:/Pobrane/adventure.jpg");
        }
        private void ButtonDownload3_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://wallpaperplay.com/walls/full/7/8/0/91245.jpg", @"Desktop/Pobrane/nba.jpg");
            Process.Start("C:/Pobrane/nba.jpg");
        }
        private void ButtonDownload4_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("http://www.cerc-ug.org/pic/b/112/1128716_cartoon-images-hd-wallpaper.jpg", @"C:/Pobrane/lion.jpg");
            Process.Start("C:/Pobrane/lion.jpg");
        }
        private void ButtonDownload5_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://cdn.suwalls.com/wallpapers/cartoons/spongebob-and-patrick-11497-400x250.jpg", @"C:/Pobrane/spongebob.jpg");
            Process.Start("C:/Pobrane/spongebob.jpg");
        }
        private void ButtonDownload6_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://wallpapercave.com/wp/0oLRuAv.jpg", @"C:/Pobrane/mario.jpg");
            Process.Start("C:/Pobrane/mario.jpg");
        }
        private void ButtonDownload7_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://i.imgur.com/A8u0nTS.jpg", @"C:/Pobrane/simpson.jpg");
            Process.Start("C:/Pobrane/simpson.jpg");
        }
        private void ButtonDownload8_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://longwallpapers.com/Desktop-Wallpaper/funny-cartoon-wallpapers-desktop-background-For-Desktop-Wallpaper.jpg", @"C:/Pobrane/sponge bob.jpg");
            Process.Start("C:/Pobrane/sponge bob.jpg");
        }

        private void ButtonCategories_Click(object sender, RoutedEventArgs e)
        {
            Categories use = new Categories();
            use.Show();
            this.Close();
        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow use = new MainWindow();
            use.Show();
            this.Close();
        }
    }
}
