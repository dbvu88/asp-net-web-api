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
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        public UsersController(IUsersTbl users)
        {
            Users = users;
        }

        public IUsersTbl Users { get; }

        [Route()]
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

        [Route("{Username}")]
        public IHttpActionResult Get(string Username)
        {
            try
            {
                var result = Users.GetUserByName(Username);
                if (result == null) return NotFound();
                return Json(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
