using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSchoolClass.Enums
{
        public enum DataConnectionResource : Int32
        {
        [StringValue("Server=localhost;Port=3306; Database = musicschoolbdd;Uid = root;Pwd =;")]GENERICMYSQL = 1,

        [StringValue("Server=localhost;Port=3306; Database = musicschoolbdd;Uid = root;Pwd =;")]LOCALMYQSL = 2, [StringValue("http://localhost:52086/api/")]LOCALAPI = 3,
         }
}
