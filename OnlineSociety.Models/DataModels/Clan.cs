using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSociety.Models.DataModels
{
    public class Clan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Members { get; set; }
    }
}
