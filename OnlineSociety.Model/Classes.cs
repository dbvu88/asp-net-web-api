using System;
using System.Collections.Generic;

namespace OnlineSociety.Classes
{

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public bool Restricted { get; set; }
        public Clan Clan { get; set; }
        public int ClantId { get; set; }
        public List<Pet> Pets { get; set; }
    }

    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PetType Type { get; set; }
    }

    public class Clan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Members { get; set; }

    }

    public enum PetType
    {
        Mutant = 1,
        Alien = 2,
        Wild = 3,
        Domestic = 4
    }
}

