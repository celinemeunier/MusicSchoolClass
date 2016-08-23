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
    /// Logique d'interaction pour PageStudent.xaml
    /// </summary>
    public partial class PageStudent : Page
    {
        private StudentViewModel studentViewModel;
        public StudentUserControl StudentUserControl { get; set; }

        public PageStudent()
        {
            InitializeComponent();
            this.StudentUserControl = this.ucStudentUserControl;
            this.studentViewModel = new StudentViewModel(this);
        }

    }   
}
