using MusicSchoolClass.Base;
using MusicSchoolClass.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicSchoolClass.Models
{
    [Table("numberRoom")]
    public class Teacher : EntityBase
    {
        #region Attributes
        private Int32 id;
        private String name;
        private String surname;
        private String mail;
        private String username;
        private String password;
        private String instrumentName;
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
            set{name = value;this.OnPropertyChanged("Name");}
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

        [Column("instrument")]
        public String InstrumentName
        {
            get{return instrumentName; }
            set{instrumentName = value; this.OnPropertyChanged("Instruments");}
        }

        #endregion

        #region Constructor
        #endregion

        #region Methods
        #endregion
    }
}

