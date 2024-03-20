using Domain.Animals;
using Logic.Services.Animals.DogService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_2_Unit_Test.FakeRepo
{
    public class FakeDogDB : IDogDB
    {
        public List<Dog> dogs { get;  }
        public FakeDogDB()
        {
            dogs = new List<Dog>();
        }

        public void CreateDog(Dog d)
        {
            dogs.Add(d);
        }

        public void DeleteDog(Dog d)
        {
            dogs.Remove(d);
        }

        public Dog GetDogByID(int id)
        {
            foreach(var v in dogs)
            {
                if (v.id == id)
                    return v;
            };
            return null;
        }

        public List<Dog> ReadAllDogs()
        {
            return dogs;
        }

        public void UpdateDog(Dog d)
        {
            dogs[d.id-1] = d;
        }
    }
}
