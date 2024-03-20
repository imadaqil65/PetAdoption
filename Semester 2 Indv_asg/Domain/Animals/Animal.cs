using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.enums;
using Domain.Shelters;

namespace Domain.Animals
{
    public class Animal
    {
        public int? adopter_id { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string shelter { get; set; }
        public int shelterid { get; set; }
        public Species species { get; set; }
        public int age { get; set; }
        public Gender gender { get; set; }
        public string? description { get; set; }
        public string imagelink { get; set; }
        public bool isAdopted { get; set; }

        public Gender Gender
        {
            get => default;
            set
            {
            }
        }

        public Species Species
        {
            get => default;
            set
            {
            }
        }

        public Shelter Shelter
        {
            get => default;
            set
            {
            }
        }

        public Animal() { }

        public Animal(string name, int shelterid, Species species, int age, Gender gender, string? description, string imagelink)
        {
            this.name = name;
            this.shelterid = shelterid;
            this.species = species;
            this.gender = gender;
            this.age = age;
            this.description = description;
            this.imagelink = imagelink;
        }

        public Animal(int id, string name, int shelterid, string shelter, Species species, int age, Gender gender, string? description, string imagelink)
        {
            this.id = id;
            this.name = name;
            this.shelterid = shelterid;
            this.shelter = shelter;
            this.species = species;
            this.gender = gender;
            this.age = age;
            this.description = description;
            this.imagelink = imagelink;
        }

        public Animal(string name, string shelter, Species species, int age, Gender gender, string? description, string imagelink)
        {
            this.name = name;
            this.shelter = shelter;
            this.species = species;
            this.gender = gender;
            this.age = age;
            this.description = description;
            this.imagelink = imagelink;
        }

        public Animal(int? adopter_id, bool isAdopted, int id, string name, int shelterid, string shelter, Species species, int age, Gender gender, string? description, string imagelink)
        {
            this.adopter_id = adopter_id;
            this.isAdopted = isAdopted;
            this.id = id;
            this.name = name;
            this.shelterid = shelterid;
            this.shelter = shelter;
            this.species = species;
            this.gender = gender;
            this.age = age;
            this.description = description;
            this.imagelink = imagelink;
        }
    }
}
