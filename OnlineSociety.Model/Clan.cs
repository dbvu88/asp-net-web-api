﻿using System.Collections.Generic;

namespace OnlineSociety.Model
{
    public class Clan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Members { get; set; }
    }
}

