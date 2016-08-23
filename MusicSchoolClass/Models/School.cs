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
    [Table("school")]
    public class School : EntityBase
    {
        #region Attributes
        private Int32 id;
        private String address;
        private Int32 phone;
        #endregion

        #region Properties
        [Key]
        [Column("id")]
        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }

        }

        [Column("adress")]
        public String Address
        {
            get{return address;}
            set{address = value;this.OnPropertyChanged("Adress");}
        }

        [Column("phone")]
        public Int32 Phone
        {
            get{return phone;}
            set{phone = value;this.OnPropertyChanged("Phone");
            }
        }
        #endregion

        #region Constructor
        #endregion

        #region Methods
        #endregion
    }
}
