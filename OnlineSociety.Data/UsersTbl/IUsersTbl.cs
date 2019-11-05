using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSociety.Model.UsersTbl
{
    public interface IUsersTbl
    {
        IEnumerable<User> GetUsers();
        User GetUserByName(string username);
    }
}
