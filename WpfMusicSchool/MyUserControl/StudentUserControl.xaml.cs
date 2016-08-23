
using MusicSchoolClass.Models;
using WpfMusicSchool.MyUserControl.Base;


namespace WpfMusicSchool.MyUserControl
{
    public sealed partial class StudentUserControl : BaseUserControl
    {
        #region Attributes
        private Student student;
        #endregion


        #region properties
        public Student Student
        {
            get{return this.student;}
            set{
                this.student = value;
                base.OnPropertyChanged("Student");
            }
        }
        #endregion


        #region Constructor
        public StudentUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        #endregion
    }
}