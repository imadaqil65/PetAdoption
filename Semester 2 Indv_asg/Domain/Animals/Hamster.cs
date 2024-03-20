using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.enums;

namespace Domain.Animals
{
    public class Hamster : Animal
    {
        public string breed { get; set; }
        public string food { get; set; }
        public string habitat { get; set; }
        public Hamster(string name, string shelter, Species species, int age, Gender gender, string breed, string food, string habitat, string? description, string imagelink) : base(name, shelter, species, age, gender, description, imagelink)
        {
            this.breed = breed;
            this.food = food;
            this.habitat = habitat;
        }
        public Hamster(int id, string name, int shelterid, string shelter, Species species, int age, Gender gender, string breed, string food, string habitat, string? description, string imagelink) : base(id, name, shelterid, shelter, species, age, gender, description, imagelink)
        {
            this.breed = breed;
            this.food = food;
            this.habitat = habitat;
        }
    }
}
