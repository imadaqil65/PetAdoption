using Domain.Shelters;
using Logic.Services.ShelterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_2_Unit_Test.FakeRepo
{
    public class FakeShelterDB : IShelterDB
    {
        public List<Shelter> shelters { get; }

        public FakeShelterDB() 
        { 
            shelters = new List<Shelter>(); 
        }

        public void CreateShelter(Shelter s)
        {
            shelters.Add(s);
        }

        public void DeleteShelter(Shelter s)
        {
            shelters.Remove(s);
        }

        public Shelter GetShelterById(int id)
        {
            foreach(var v in shelters)
            {
                if (v.id == id)
                {
                    return v;
                }
            };
            return null;
        }

        public List<Shelter> ReadAllShelters()
        {
            return shelters;
        }

        public void UpdateShelter(Shelter s)
        {
            shelters[s.id - 1] = s;
        }
    }
}
