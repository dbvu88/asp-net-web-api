﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSociety.Models.ViewModels
{
    public class UserModel
    {
        public string Username { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Clan { get; set; }
        public ICollection<PetModel> Pets {get; set;}
}
}
