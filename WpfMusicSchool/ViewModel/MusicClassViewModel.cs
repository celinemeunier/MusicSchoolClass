using MusicSchoolClass.API;
using MusicSchoolClass.DataBase;
using MusicSchoolClass.Enums;
using MusicSchoolClass.Models;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using WpfMusicSchool.View;
using System;
using System.Windows.Media;
using WpfMusicSchool.View.Pages;
using MusicSchoolClass.Logger;

namespace WpfMusicSchool.ViewModel
{
    public class MusicClassViewModel
    {
        #region Attributes
        private PageSchool pageSchool;
        MySQLManager<MusicClass> musicClass1;
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public MusicClassViewModel(PageSchool pageSchool)
        {
            this.pageSchool = pageSchool;
            musicClass1 = new MySQLManager<MusicClass>(DataConnectionResource.LOCALMYQSL);

            LoadItems();
            LinkItems();
        }



        private void LinkItems()
        {

        }

        private async void LoadItems()
        {
            MusicClass mc1 = new MusicClass();
            mc1.ClassAge = 8;
            mc1.ClassExperience = 1;
            mc1.NumberUser = 10;

            await musicClass1.Insert(mc1);
            var result = this.pageSchool.ucMusicClassUserControl.MusicClass= await musicClass1.Get(1);
            this.pageSchool.ucMusicClassUserControl.MusicClass = result;
            
        }


        #endregion

        WebServiceManager<MusicClass> webServiceA =
                new WebServiceManager<MusicClass>(DataConnectionResource.LOCALAPI);

    }
}