
using MusicSchoolClass.Models;
using WpfMusicSchool.MyUserControl.Base;


namespace WpfMusicSchool.MyUserControl
{ 
    public sealed partial class MusicClassUserControl : BaseUserControl
    {
        #region Attributes
        private MusicClass musicClass;
        #endregion


        #region properties
        public MusicClass MusicClass
        {
            get { return this.musicClass; }
            set
            {
                this.musicClass = value;
                base.OnPropertyChanged("MusicClass");
            }
        }
        #endregion


        #region Constructor
        public MusicClassUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }

       
        
        #endregion
    }
}

