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
    /// Logika interakcji dla klasy Graphic.xaml
    /// </summary>
    public partial class Graphic : Window
    {
        public Graphic()
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
            client.DownloadFile("https://dreamsky10.com/wp-content/uploads/2017/07/4K-Wallpaper-royalty-free-photos-fantasy-desktop-wallpaper-by-md.sopon1_.jpg", @"C:/Pobrane/space.jpg");
            Process.Start("C:/Pobrane/space.jpg");
        }
        private void ButtonDownload2_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://hdqwalls.com/download/firewatch-game-graphics-1920x1080.jpg", @"C:/Pobrane/deer.jpg");
            Process.Start("C:/Pobrane/deer.jpg");
        }
        private void ButtonDownload3_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://images3.alphacoders.com/220/220925.jpg", @"Desktop/Pobrane/yellowBG.jpg");
            Process.Start("C:/Pobrane/yellowBG.jpg");
        }
        private void ButtonDownload4_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("http://sfwallpaper.com/images/awesome-graphic-wallpapers-18.jpg", @"C:/Pobrane/circles.jpg");
            Process.Start("C:/Pobrane/circles.jpg");
        }
        private void ButtonDownload5_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://cdn.wallpapersafari.com/13/65/qCKxnz.jpg", @"C:/Pobrane/apple.jpg");
            Process.Start("C:/Pobrane/apple.jpg");
        }
        private void ButtonDownload6_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://i.pinimg.com/originals/b6/b2/f2/b6b2f2864fd1f2258d90ae7abdcff44f.jpg", @"C:/Pobrane/musicBG.jpg");
            Process.Start("C:/Pobrane/musicBG.jpg");
        }
        private void ButtonDownload7_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://d2v9y0dukr6mq2.cloudfront.net/video/thumbnail/HPOKFbR/rotating-baseball-ball-as-3d-animated-sports-motion-graphics-background-in-full-hd-1920x1080-progressive-resolution_n1qfjxxe__F0000.png", @"C:/Pobrane/baseball.jpg");
            Process.Start("C:/Pobrane/baseball.jpg");
        }
        private void ButtonDownload8_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://cdn.wallpapersafari.com/85/88/ZUuzQm.jpg", @"C:/Pobrane/rainbow.jpg");
            Process.Start("C:/Pobrane/rainbow.jpg");
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
