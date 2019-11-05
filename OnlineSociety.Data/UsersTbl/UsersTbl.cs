using OnlineSociety.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OnlineSociety.Model.UsersTbl
{
    public class UsersTbl : IUsersTbl
    {
        private readonly OnlineSocietyContext _context;

        public UsersTbl(OnlineSocietyContext context)
        {
            this._context = context;
        }

        public User GetUserByName(string name)
        {
            return _context.Users.FirstOrDefault(t => t.Username == name);
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
