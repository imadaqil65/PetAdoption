using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.enums;

namespace Domain.Animals
{
    public class Bird : Animal
    {
        public string breed {get; set;}
        public bool voicemimic { get; set; }
        public int wingspan { get; set; }
        public ActivityLevel activityLevel { get; set; }

        public ActivityLevel ActivityLevel
        {
            get => default;
            set
            {
            }
        }

        public Bird(string name, int shelterid, Species species, int age, Gender gender, string breed, bool voicemimic, int wingspan, ActivityLevel activityLevel, string? description, string imagelink) : base(name, shelterid, species, age, gender, description, imagelink)
        {
            this.breed = breed;
            this.voicemimic = voicemimic;
            this.wingspan = wingspan;
            this.activityLevel = activityLevel;
        }
        public Bird(int? adopter_id, bool isAdopted, int id, string name, int shelterid, string shelter, Species species, int age, Gender gender, string breed, bool voicemimic, int wingspan, ActivityLevel activityLevel,string? description, string imagelink) : base(adopter_id, isAdopted, id, name, shelterid, shelter, species, age, gender, description, imagelink)
        {
            this.breed = breed;
            this.voicemimic=voicemimic;
            this.wingspan = wingspan;
            this.activityLevel = activityLevel;
        }
    }
}
