using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.enums;

namespace Domain.Animals
{
    public class Dog : Animal
    {
        public string breed { get; set;}
        public bool housetrained { get; set; }
        public bool sterile { get; set; }
        public ActivityLevel activityLevel { get; set; }

        public ActivityLevel ActivityLevel
        {
            get => default;
            set
            {
            }
        }

        public Dog() { }

        public Dog(string name, int shelterid, Species species, int age, Gender gender, string breed, bool housetrained, bool sterile, ActivityLevel activityLevel, string? description, string imagelink) : base(name, shelterid, species, age, gender, description, imagelink)
        {
            this.breed = breed;
            this.housetrained = housetrained;
            this.sterile = sterile;
            this.activityLevel = activityLevel;
        }
        public Dog(int? adopter_id, bool isAdopted, int id, string name, int shelterid, string shelter, Species species, int age, Gender gender, string breed, bool housetrained, bool sterile, ActivityLevel activityLevel, string? description, string imagelink) : base(adopter_id, isAdopted, id, name, shelterid, shelter, species, age, gender, description, imagelink)
        {
            this.breed = breed;
            this.housetrained = housetrained;
            this.sterile = sterile;
            this.activityLevel = activityLevel;
        }
    }
}
