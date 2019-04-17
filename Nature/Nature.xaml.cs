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
    /// Logika interakcji dla klasy Nature.xaml
    /// </summary>
    public partial class Nature : Window
    {
        public Nature()
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
            client.DownloadFile("https://www.hdwallpapers.in/thumbs/2012/enchanted_forest-t2.jpg", @"C:/Pobrane/forest.jpg");
            Process.Start("C:/Pobrane/forest.jpg");
        }
        private void ButtonDownload2_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://images.pexels.com/photos/457882/pexels-photo-457882.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", @"C:/Pobrane/beach.jpg");
            Process.Start("C:/Pobrane/beach.jpg");
        }
        private void ButtonDownload3_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://images.wallpaperscraft.com/image/mountain_lodge_top_snow_92237_1920x1080.jpg", @"Desktop/Pobrane/mountainHouse.jpg");
            Process.Start("C:/Pobrane/mountainHouse.jpg");
        }
        private void ButtonDownload4_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://www.hdwallpapers.in/download/android_mountains-wide.jpg", @"C:/Pobrane/pinkmountain.jpg");
            Process.Start("C:/Pobrane/pinkmountain.jpg");
        }
        private void ButtonDownload5_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://wallpapercave.com/wp/9cJmNaw.jpg", @"C:/Pobrane/forest.jpg");
            Process.Start("C:/Pobrane/forest.jpg");
        }
        private void ButtonDownload6_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://s-media-cache-ak0.pinimg.com/originals/49/79/1e/49791e99374cad7a575cf73d251dc4c0.jpg", @"C:/Pobrane/waterfall.jpg");
            Process.Start("C:/Pobrane/waterfall.jpg");
        }
        private void ButtonDownload7_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://wallpaperplay.com/walls/full/5/7/9/112256.jpg", @"C:/Pobrane/mountain.jpg");
            Process.Start("C:/Pobrane/mountain.jpg");
        }
        private void ButtonDownload8_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://images4.alphacoders.com/947/thumb-1920-94714.jpg", @"C:/Pobrane/desert.jpg");
            Process.Start("C:/Pobrane/desert.jpg");
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
