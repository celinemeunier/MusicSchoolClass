using MusicSchoolClass.Models.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSchoolClass.Models
{
    public class NotifiedClass : IInvestor
    {

        
        private Int32 id;
        

        
        public int Id
        {
            get { return id; }
            set { id = value; }

        }

        public void Update(object toSee)
        {
            
            throw new NotImplementedException();
            Console.WriteLine(toSee);

        }
    
    }
         
}
