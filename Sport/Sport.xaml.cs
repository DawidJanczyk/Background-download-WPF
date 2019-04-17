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
    /// Logika interakcji dla klasy Sport.xaml
    /// </summary>
    public partial class Sport : Window
    {
        public Sport()
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
            client.DownloadFile("https://hdqwalls.com/download/fc-barcelona-1920x1080.jpg", @"C:/Pobrane/barca.jpg");
            Process.Start("C:/Pobrane/barca.jpg");
        }
        private void ButtonDownload2_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://images.wallpaperscraft.com/image/skier_ski_jump_fly_sky_sun_mountains_76610_1920x1080.jpg", @"C:/Pobrane/skijump.jpg");
            Process.Start("C:/Pobrane/skijump.jpg");
        }
        private void ButtonDownload3_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://stmed.net/sites/default/files/swimming-wallpapers-31408-6825423.jpg", @"Desktop/Pobrane/swimming.jpg");
            Process.Start("C:/Pobrane/swimming.jpg");
        }
        private void ButtonDownload4_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://www.pixelstalk.net/wp-content/uploads/2015/12/GOLDEN-STATE-WARRIORS-NBA-basketball-wallpapers.jpg", @"C:/Pobrane/GSW.jpg");
            Process.Start("C:/Pobrane/GSW.jpg");
        }
        private void ButtonDownload5_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://images.alphacoders.com/266/266803.jpg", @"C:/Pobrane/real.jpg");
            Process.Start("C:/Pobrane/real.jpg");
        }
        private void ButtonDownload6_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("http://school298.spb.ru/images/200/DSC100228421.jpg", @"C:/Pobrane/Ball.jpg");
            Process.Start("C:/Pobrane/Ball.jpg");
        }
        private void ButtonDownload7_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://i.pinimg.com/originals/45/ff/5c/45ff5c1765f453edfd0b48e3bd24e881.jpg", @"C:/Pobrane/snowboard.jpg");
            Process.Start("C:/Pobrane/snowboard.jpg");
        }
        private void ButtonDownload8_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://allhdwallpapers.com/wp-content/uploads/2015/05/Cycling-6.jpg", @"C:/Pobrane/cycling.jpg");
            Process.Start("C:/Pobrane/cycling.jpg");
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
