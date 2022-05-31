using System;
using System.Collections.Generic;

#nullable disable

namespace MyDatabase.DataAccess.EF.Models
{
    public partial class Pet
    {
        public int PetId { get; set; }
        public string PetName { get; set; }
        public string Species { get; set; }
        public short BirthYear { get; set; }
        public string Diet { get; set; }
        public string Veterinarian { get; set; }
        public string Vaccine { get; set; }
        public DateTime DateAdministered { get; set; }
    }
}
