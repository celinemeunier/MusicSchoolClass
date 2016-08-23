using MusicSchoolClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApplication2.Controllers.Base;

namespace WebApplication2.Controllers
{
    public class StudentController : BaseController<Student>
    {
        [Route("api/Students")]
        public override Task<IHttpActionResult> Post(IEnumerable<Student> values)
        {
            return base.Post(values);
        }

        [Route("api/Students")]
        public override Task<IHttpActionResult> Put(IEnumerable<Student> values)
        {
            return base.Put(values);
        }

        [Route("api/Students")]
        public override Task<IHttpActionResult> Delete(IEnumerable<Student> values)
        {
            return base.Delete(values);
        }
    }
}

