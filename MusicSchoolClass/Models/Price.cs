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
    [Table("price")]
    public class Price : EntityBase
    {
        #region Attributes
        private Int32 id;
        private Int32 yearPrice;
        private Int32 monthPrice;
        private Int32 hourPrice;
        private Int32 locationPrice;
        #endregion

        #region Properties
        [Key]
        [Column("id")]
        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }

        }
        [Column("yearPrice")]
        public Int32 YearPrice
        {
            get{return yearPrice;}
            set{yearPrice = value;this.OnPropertyChanged("YearPrice"); }
        }

        [Column("monthPrice")]
        public Int32 MonthPrice
        {
            get{return monthPrice;}
            set{monthPrice = value; this.OnPropertyChanged("MonthPrice"); }
        }

        [Column("hourPrice")]
        public Int32 HourPrice
        {
            get{return hourPrice;}
            set{hourPrice = value; this.OnPropertyChanged("HourPrice");}
    }

        [Column("locationPrice")]
        public Int32 LocationPrice
        {
            get{return locationPrice;}
            set{locationPrice = value; this.OnPropertyChanged("LocationPrice"); }
        }
        #endregion

        #region Constructor
        #endregion

        #region Methods
        #endregion
    }
}
