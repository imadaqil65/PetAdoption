using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.enums;

namespace Domain.Animals
{
    public class Cat : Animal
    { 
        public string breed { get; set; }
        public string furcolor { get; set; }
        public string allergies { get; set; }
        public bool IsSterile { get; set; }

        public Cat(string name, int shelterid, Species species, int age, Gender gender, string breed, string furcolor, string allergies, bool IsSterile, string? description, string imagelink) : base(name, shelterid, species, age, gender, description, imagelink)
        {
            this.breed = breed;
            this.furcolor = furcolor;
            this.allergies = allergies;
            this.IsSterile = IsSterile;
        }
        public Cat(int? adopter_id, bool isAdopted, int id, string name, int shelterid, string shelter, Species species, int age, Gender gender, string breed, string furcolor, string allergies, bool IsSterile, string? description, string imagelink) : base(adopter_id, isAdopted, id, name, shelterid, shelter, species, age, gender, description, imagelink)
        {
            this.breed = breed;
            this.furcolor = furcolor;
            this.allergies = allergies;
            this.IsSterile = IsSterile;
        }

    }
}
