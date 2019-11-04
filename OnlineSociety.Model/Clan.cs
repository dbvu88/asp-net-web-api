using System.Collections.Generic;

namespace OnlineSociety.Classes
{
    public class Clan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Members { get; set; }
    }
}

