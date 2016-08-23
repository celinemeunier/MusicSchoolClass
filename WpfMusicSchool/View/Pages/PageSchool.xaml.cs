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
using WpfMusicSchool.MyUserControl;
using WpfMusicSchool.ViewModel;

namespace WpfMusicSchool.View.Pages
{
    /// <summary>
    /// Logique d'interaction pour PageSchool.xaml
    /// </summary>
    public partial class PageSchool : Page
    {
        private MusicClassViewModel musicClassViewModel;
        public MusicClassUserControl MusicClassUserControl { get; set; }

        public PageSchool()
        {
            InitializeComponent();
            this.MusicClassUserControl = this.ucMusicClassUserControl;
            this.musicClassViewModel = new MusicClassViewModel(this);
           
        }

    }
}
