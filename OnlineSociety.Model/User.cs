using System;
using System.Collections.Generic;

namespace OnlineSociety.Model
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

