using AutoMapper.Configuration;
using OnlineSociety.Models.DataModels;
using System.Configuration;
using System.Data.Entity;

namespace OnlineSociety.DataService
{
    public class OnlineSocietyContext : DbContext
    {
        public OnlineSocietyContext()
        {
            this.Database.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["OnlineSocietyContext"].ConnectionString;
        }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }
    }
}
