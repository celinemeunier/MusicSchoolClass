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
using WpfMusicSchool.View.Pages;

namespace WpfMusicSchool.View
{
    /// <summary>
    /// Logique d'interaction pour Accueil.xaml
    /// </summary>
    public partial class Accueil : Page
    {
        public Accueil()
        {
            InitializeComponent();
        }


    
        private void NavigationpTeacher_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PageTeacher());
        }

        private void NavigationpSchool_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PageSchool());
        }

        private void NavigationpStudent_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PageStudent());
        }
    }
}
