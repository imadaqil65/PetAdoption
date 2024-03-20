using Domain.Shelters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services.ShelterService
{
    public interface IShelterDB
    {
        public void CreateShelter(Shelter s);
        public void UpdateShelter(Shelter s);
        public void DeleteShelter(Shelter s);
        public List<Shelter> ReadAllShelters();
        public Shelter GetShelterById(int id);
    }
}
