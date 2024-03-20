using System;
using Domain.Animals;
using Domain.enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Services.Animals.CatService;

namespace Logic.Services.Animals.DogService
{
	public class DogManager
	{
        IDogDB datasource;

        public DogManager(IDogDB datasource)
        {
            this.datasource = datasource;
        }

        public void NewDog(Dog dog)
        {
            datasource.CreateDog(dog);
        }

        public List<Dog> GetAllDogs()
        {
            return datasource.ReadAllDogs();
        }

        public List<Dog> GetDogs()
        {
            List<Dog> dogs = new List<Dog>();
            foreach (Dog d in GetAllDogs())
            {
                if(d.isAdopted == false)
                dogs.Add(d);
            }
            return dogs;
        }

        public Dog GetDog(int id)
        {
            return datasource.GetDogByID(id);
        }

        public void UpdateDog(Dog d)
        {
            datasource.UpdateDog(d);
        }

        public void DeleteDog(Dog d)
        {
            datasource.DeleteDog(d);
        }
    }
}
