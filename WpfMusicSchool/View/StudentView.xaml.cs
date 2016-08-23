using MusicSchoolClass.Logger;
using MusicSchoolClass.Models;
using MusicSchoolClass.Models.Observable;
using System.Windows.Controls;
using WpfMusicSchool.MyUserControl;
using WpfMusicSchool.ViewModel;

namespace WpfMusicSchool.View
{
    public sealed partial class StudentView : Page
    {
        #region attributs
        private StudentViewModel studentViewModel;
        #endregion

        #region properties
        public StudentUserControl StudentUserControl { get; set; }
        
        public StudentUserControl UCStudent{ get; private set; }


        #endregion

        #region constructor
        public StudentView()
        {
            InitializeComponent();
            this.StudentUserControl = this.UCStudent;
           // this.studentViewModel = new StudentViewModel(this);
        }

        private void Observabler() {
            ObservedClass obs = new ObservedClass();
            NotifiedClass n1 = new NotifiedClass();
            NotifiedClass n2 = new NotifiedClass();

            obs.Attach(n1);
            obs.Attach(n1);
        }
        
        #endregion


        #region methods

        #endregion
        private void navigation_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Accueil());
        }
       
    }
}

