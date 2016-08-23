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
    public class StudentViewModel
    {
        #region Attributes
        private PageStudent pageStudent;
        MySQLManager<Student> student1;
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public StudentViewModel(PageStudent pageStudent)
        {
            this.pageStudent = pageStudent;
            student1 = new MySQLManager<Student>(DataConnectionResource.LOCALMYQSL);
            
            LoadItems();
            LinkItems();
        }

        private void Logs()
        {
            Logger logger = new Logger(LogMode.CURRENT_FOLDER, AlertMode.NONE);
            logger.log("bonjour", "mon message"); 
        }

        private void LinkItems()
        {
           
        }

        private async void LoadItems()
        {
            Student s1 = new Student();
            s1.Name = "John";
            s1.Surname = "Doe";
            s1.Age = 15;
            s1.Mail = "JDoe@exemple.fr";
            s1.Password = "cestmoi";
            s1.Username = "JDoe";
            await student1.Insert(s1);
            

            Student s2 = new Student();
            s2.Name = "Pierre";
            s2.Surname = "Paul";
            s2.Age = 21;
            s2.Mail = "PPaul@exemple.fr";
            s2.Password = "coucou";
            s2.Username = "PP";
            await student1.Insert(s2);
            var result = this.pageStudent.ucStudentUserControl.Student = await student1.Get(1);
        }

      
        #endregion

        WebServiceManager<Student> webServiceA =
                new WebServiceManager<Student>(DataConnectionResource.LOCALAPI);
        private StudentView StudentView;
      
    }
}
