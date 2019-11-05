using OnlineSociety.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSociety.Model.UsersTbl
{
    public class UsersTbl : IUsersTbl
    {
        private readonly OnlineSocietyContext _context;

        public UsersTbl(OnlineSocietyContext context)
        {
            this._context = context;
        }
        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
