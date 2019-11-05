using OnlineSociety.Model;
using OnlineSociety.Data;
using OnlineSociety.Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using OnlineSociety.Model.UsersTbl;

namespace OnlineSociety.Controllers
{
    public class UsersController : ApiController
    {
        public UsersController(IUsersTbl users)
        {
            Users = users;
        }

        public IUsersTbl Users { get; }

        // GET: Users
        public IHttpActionResult Get()
        {
            try
            {
                var results = Users.GetUsers();
                return Json(results);
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
