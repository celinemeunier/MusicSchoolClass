using MusicSchoolClass.Enums;
using MusicSchoolClass.Models;
using System;
using System.Data.Entity;

namespace MusicSchoolClass.DataBase
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]

    public class FullDb:DbContext
    {
        public DbSet<Date> DbSetDate { get; set; }
        public DbSet<Instruments> DbSetInstruments { get; set; }
        public DbSet<MusicClass> DbSetMusicClass { get; set; }
        public DbSet<Price> DbSetPrice { get; set; }
        public DbSet<Room> DbSetRoom { get; set; }
        public DbSet<School> DbSetSchool { get; set; }
        public DbSet<Student> DbSetStudent { get; set; }
        public DbSet<Teacher> DbSetTeacher { get; set; }
       

        public FullDb(DataConnectionResource dataConnectionResource) : base(EnumString.GetStringValue(dataConnectionResource))
        {
            this.Database.CreateIfNotExists();
        }
    }
}
