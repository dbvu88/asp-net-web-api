using OnlineSociety.Classes;
using System.Data.Entity;

namespace OnlineSociety.Data
{
    public class OnlineSocietyContext : DbContext
    {
        public DbSet<Clan> Clan;
        public DbSet<User> User;
        public DbSet<Pet> Pet;
    }
}
