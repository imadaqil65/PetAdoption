using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Shelters
{
    public class Shelter
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string address { get; set; }

        public Shelter(string name, string location, string address)
        {
            this.name = name;
            this.location = location;
            this.address = address;
        }
        public Shelter(int id, string name, string location, string address)
        {
            this.id = id;
            this.name = name;
            this.location = location;
            this.address = address;
        }
    }
}
