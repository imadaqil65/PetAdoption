using System;
using Domain.Animals;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services.Animals.DogService
{
	public interface IDogDB
	{
        public void CreateDog(Dog d);
        public void UpdateDog(Dog d);
        public void DeleteDog(Dog d);
        public List<Dog> ReadAllDogs();
        public Dog GetDogByID(int id);
    }
}
