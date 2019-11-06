using OnlineSociety.Models.DataModels;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSociety.DataService.Tables
{
    public interface IUsersTable
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserByNameAsync(string username);
    }

    public class UsersTable : IUsersTable
    {
        private readonly OnlineSocietyContext _context;

        public UsersTable(OnlineSocietyContext context)
        {
            this._context = context;
        }

        public async Task<User> GetUserByNameAsync(string name)
        {
            return await _context.Users
                .Include(c => c.Clan)
                .FirstOrDefaultAsync(t => t.Username == name);
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _context.Users
                .Include("Clan")
                .ToArrayAsync();
        }
    }
}
