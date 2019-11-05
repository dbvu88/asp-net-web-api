using OnlineSociety.Models.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace OnlineSociety.DataService.Tables
{
    public interface IUsersTable
    {
        IEnumerable<User> GetUsers();
        User GetUserByName(string username);
    }

    public class UsersTable : IUsersTable
    {
        private readonly OnlineSocietyContext _context;

        public UsersTable(OnlineSocietyContext context)
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
