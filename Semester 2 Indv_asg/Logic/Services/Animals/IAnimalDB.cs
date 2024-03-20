using Domain.Animals;
using Domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services.Animals
{
    public interface IAnimalDB
    {
        public void CreateAnimal(Animal a);
        public void UpdateAnimal(Animal a);
        public void DeleteAnimal(Animal a);
        public List<Animal> ReadAllAnimals();
        public List<Animal> GetAnimalBySpecies(Species species);
        public Animal GetAnimalByID(int id);
    }
}
