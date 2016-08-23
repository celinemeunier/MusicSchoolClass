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
    [Table("room")]
    public class Room : EntityBase
    {
        #region Attributes
        private Int32 id;
        private Int32 numberRoom;
        private Int32 numberPlace;
        private String materials;
        #endregion

        #region Properties
        [Key]
        [Column("id")]
        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }

        }

        [Column("numberRoom")]
        public Int32 NumberRoom
        {
            get{return numberRoom;}
            set{numberRoom = value;this.OnPropertyChanged("NumberRoom");}
        }

        [Column("numberPlace")]
        public Int32 NumberPlace
        {
            get{return numberPlace;}
            set{numberPlace = value;this.OnPropertyChanged("NumberPlace");}
        }

        [Column("materials")]
        public String Materials
        {
            get{return materials;}
            set{materials = value;this.OnPropertyChanged("Materials");}
        }
        #endregion

        #region Constructor
        #endregion

        #region Methods
        #endregion
    }
}
