using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
    public class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public bool IsAdmin { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public string? address { get; set; }
        public DateTime? birthdate { get; set; }

        public Animals.Animal Animal
        {
            get => default;
            set
            {
            }
        }

        public User(int id, string email, bool IsAdmin , string username, string password, string? firstname, string? lastname, string? address, DateTime? birthdate)
        {
            this.id = id;
            this.email = email;
            this.username = username;
            this.IsAdmin = IsAdmin;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.birthdate = birthdate;
        }
        public User(int id, string email, bool IsAdmin, string username, string password)
        {
            this.id = id;
            this.email = email;
            this.IsAdmin = IsAdmin;
            this.username = username;
            this.password = password;
        }
        public User(string email, bool IsAdmin, string username, string password)
        {
            this.email = email;
            this.IsAdmin = IsAdmin;
            this.username = username;
            this.password = password;
        }

    }
}
