using OnlineSociety.Model;
using OnlineSociety.Data;
using OnlineSociety.Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace OnlineSociety.Controllers
{
    public class UsersController : ApiController
    {
        // GET: Users
        public IHttpActionResult Get()
        {

            var dbContext = new OnlineSocietyContext();
            try
            {
                var results = dbContext.Users.ToList();
                return Json(results);
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
