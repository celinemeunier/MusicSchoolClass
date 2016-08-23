using MusicSchoolClass.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicSchoolClass.Models
{
    [Table("musicClass")]
    public class MusicClass : EntityBase
    {
        #region Attributes
        private Int32 id;
        private Int32 classAge;
        private Int32 classExperience;
        private Int32 numberUser;
        //private String Teacher.name;
        //private String instrumentClass = Instruments.instrumentName;
        //private DateTime dateClass = Date.classDate;
        private List<Student>student;
        //private Int32 RoomClass = Room.numberRoom;
        #endregion

        #region Properties

        [Key]
        [Column("id")]
        public int Id
        {
            get { return id; }
            set{ id = value; OnPropertyChanged("Id"); }


        }
            [Column("classAge")]
        public Int32 ClassAge
        {
            get {return classAge;}
            set {classAge = value;this.OnPropertyChanged("ClassAge");}
        }

        [Column("classExperience")]
        public Int32 ClassExperience
        {
            get {return classExperience;}
            set{classExperience = value;this.OnPropertyChanged("Name");}
        }

        [Column("numberUser")]
        public Int32 NumberUser
        {
            get{return numberUser;}
            set {numberUser = value;this.OnPropertyChanged("NumberUser");}
        }


        public List<Student> Student
        {
            get { return student; }
            set{student = value;this.OnPropertyChanged("Student");}
        }
        #endregion

        #region Constructor
        public MusicClass()
        {

        }
        #endregion

        #region Methods
        public new List<MusicClass> LoadMultipleItems()
        {
            List<MusicClass> result = new List<MusicClass>();
            for (int i = 0; i < Faker.Number.RandomNumber(3, 20); i++)
            {
                result.Add(LoadSingleItem());
            }
            return result;

        }

        public new MusicClass LoadSingleItem()
        {
            this.Id = Faker.Number.RandomNumber();
            MusicClass musicClass = new MusicClass();
            musicClass.Id = Faker.Number.RandomNumber();
            return musicClass;
        }
        #endregion
    }
}
