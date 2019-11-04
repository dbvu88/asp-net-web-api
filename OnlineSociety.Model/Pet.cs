using System.ComponentModel.DataAnnotations;

namespace OnlineSociety.Classes
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PetType Type { get; set; }
        [Required]
        public User Owner { get; set; }
        //public int UserId { get; set; }
    }
}

