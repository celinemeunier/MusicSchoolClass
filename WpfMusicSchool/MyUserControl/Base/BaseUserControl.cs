using System.ComponentModel;
using System.Windows.Controls;

namespace WpfMusicSchool.MyUserControl.Base
{
    public class BaseUserControl : UserControl, INotifyPropertyChanged
    {
        #region attributs
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region properties

        #endregion

        #region constructor

        #endregion

        #region methods
        public void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        public class Usercontrol
        {
        }
        #endregion
    }
}
