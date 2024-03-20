using Domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Adoption
{
    public class PendingAdoption
    {
        public int Adoption_id { get; set; }
        public int User_id { get; set; }
        public int Animal_id { get; set; }
        public string Animal_name { get; set; }
        public Species species { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string customerAddress { get; set; }
        public string sheltername { get; set; }
        public string shelterAddress { get; set; }

        public Animals.Animal Animal
        {
            get => default;
            set
            {
            }
        }

        public Users.User User
        {
            get => default;
            set
            {
            }
        }

        public PendingAdoption(int adoption_id, int user_id, int animal_id)
        {
            Adoption_id = adoption_id;
            User_id = user_id;
            Animal_id = animal_id;
        }
        public PendingAdoption(int user_id, int animal_id)
        {
            User_id = user_id;
            Animal_id = animal_id;
        }

        public PendingAdoption(int adoption_id, int user_id, int animal_id, string animal_name, Species species, string firstname, string lastname, string customerAddress, string sheltername, string shelterAddress) : this(adoption_id, user_id, animal_id)
        {
            Animal_name = animal_name;
            this.species = species;
            this.firstname = firstname;
            this.lastname = lastname;
            this.customerAddress = customerAddress;
            this.sheltername = sheltername;
            this.shelterAddress = shelterAddress;
        }
    }
}
