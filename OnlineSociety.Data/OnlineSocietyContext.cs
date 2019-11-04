using OnlineSociety.Model;
using OnlineSociety.Model;
using System.Data.Entity;

namespace OnlineSociety.Data
{
    public class OnlineSocietyContext : DbContext
    {
        public DbSet<Clan> Clans { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }
    }
}
