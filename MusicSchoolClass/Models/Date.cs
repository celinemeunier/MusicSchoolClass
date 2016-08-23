using MusicSchoolClass.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSchoolClass.Models
{
    [Table("date")]
    public class Date : EntityBase
    {
        #region Attributes

        private Int32 id;
        private DateTime classDate;
        private Int32 classTime;
        #endregion

        #region Properties
        [Column("classDate")]
        public DateTime ClassDate
        {
            get{return classDate;}
            set{classDate = value;this.OnPropertyChanged("ClassDate");}
        }

        [Column("classTime")]
        public Int32 ClassTime
        {
            get{return classTime;}
            set{classTime = value;this.OnPropertyChanged("ClassTime");}
        }

        [Key]
        [Column("id")]
        public int Id
        {
            get{return id;}
            set { id = value; OnPropertyChanged("Id"); }
               
        }


        #endregion

        #region Constructors

        #endregion
        #region Methods

        #endregion
    }

}

