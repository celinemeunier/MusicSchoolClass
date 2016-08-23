using MusicSchoolClass.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSchoolClass.Models
{
    [Table("student")]
    public class Student : EntityBase
    {
        #region Attributes
        private Int32 id;
        private String name;
        private String surname;
        private String mail;
        private Int32 age;
        private String username;
        private String password;
        #endregion

        #region Properties
        [Key]
        [Column("id")]
        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }

        }

        [Column("name")]
        public String Name
        {
            get{return name;}
            set{name = value;this.OnPropertyChanged("Name");
            }
        }

        [Column("surname")]
        public String Surname
        {
            get{return surname;}
            set{surname = value;this.OnPropertyChanged("Surname");}
        }

        [Column("mail")]
        public String Mail
        {
            get{return mail;}   
            set{mail = value;this.OnPropertyChanged("Mail");}
        }

        [Column("age")]
        public Int32 Age
        {
            get{return age;}
            set{age = value;this.OnPropertyChanged("Age");}
        }

        [Column("username")]
        public String Username
        {
            get{return username;}
            set{username = value;this.OnPropertyChanged("Username");}
        }

        [Column("password")]
        public String Password
        {
            get{return password;}       
            set{password = value;this.OnPropertyChanged("Password");}
        }

        
        #endregion

        #region Constructor
        public Student()
        {

        }
        #endregion

        #region Methods
        public new List<Student> LoadMultipleItems()
        {
            List<Student> result = new List<Student>();
            for (int i = 0; i < Faker.Number.RandomNumber(3, 20); i++)
            {
                result.Add(LoadSingleItem());
            }
            return result;

        }

        public new Student LoadSingleItem()
        {
            this.Id = Faker.Number.RandomNumber();
            Student student = new Student();
            student.Id = Faker.Number.RandomNumber();
            return student;
        }
        #endregion
    }

}
