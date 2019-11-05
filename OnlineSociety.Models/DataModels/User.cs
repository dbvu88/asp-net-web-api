using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSociety.Models.DataModels
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public bool Restricted { get; set; }
        public Clan Clan { get; set; }
        public int ClanId { get; set; }
        public List<Pet> Pets { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
