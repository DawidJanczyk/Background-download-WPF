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

namespace Backgrounds_app
{
    /// <summary>
    /// Logika interakcji dla klasy Categories.xaml
    /// </summary>
    public partial class Categories : Window
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        { 
           Environment.Exit(0);
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
        private void ButtonSport_Click(object sender, RoutedEventArgs e)
        {
            Sport use = new Sport();
            use.Show();
            this.Close();
        }

        private void ButtonNature_Click(object sender, RoutedEventArgs e)
        { 
             Nature use = new Nature();
             use.Show();
             this.Close();
          
        }

        private void ButtonCartoon_Click(object sender, RoutedEventArgs e)
        {
            Cartoon use = new Cartoon();
            use.Show();
            this.Close();
        }

        private void ButtonGraphic_Click(object sender, RoutedEventArgs e)
        {
            Graphic use = new Graphic();
            use.Show();
            this.Close();
        }
    }
}
