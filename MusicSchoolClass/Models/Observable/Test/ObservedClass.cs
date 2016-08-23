using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSchoolClass.Models.Observable
{
    public class ObservedClass : Observable
    {
        private Int32 Id;

        public int Id1
        {
            get{return Id;}
            set{Id = value;}
        }

        public void Update(object toSee)
        {
             Console.WriteLine(toSee);
             throw new NotImplementedException();
        }
    }
}
