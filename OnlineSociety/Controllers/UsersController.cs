using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace OnlineSociety.Controllers
{
    public class UsersController : ApiController
    {
        // GET: Users
        public async Task<IHttpActionResult> Get()
        {
            return Ok(new { username = "SuperLady", role = "Super Admin" });
        }
    }
}
