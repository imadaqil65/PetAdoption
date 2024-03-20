using Domain.Animals;
using Domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services.Animals
{
    public class AnimalManager
    {
        IAnimalDB datasource;

        public AnimalManager(IAnimalDB datasource)
        {
            this.datasource = datasource;
        }

        public void CreateAnimal(Animal a)
        {
            datasource.CreateAnimal(a);
        }

        public List<Animal> GetAnimals()
        {
            return datasource.ReadAllAnimals();
        }

        public List<Animal> GetNonAdoptedAnimals() 
        {
            List<Animal> animals = new List<Animal>();
            foreach(Animal animal in GetAnimals())
            {
                if(animal.isAdopted == false)
                {
                    animals.Add(animal);
                }
            }
            return animals;
        }

        public List<Animal> GetNonAdoptedByShelter(int id)
        {
            List<Animal> animals = new List<Animal>();
            foreach (Animal animal in GetAnimals())
            {
                if (animal.isAdopted == false && animal.shelterid == id)
                {
                    animals.Add(animal);
                }
            }
            return animals;
        }

        public List<Animal> GetAdoptedAnimals()
        {
            List<Animal> animals = new List<Animal>();
            foreach (Animal animal in GetAnimals())
            {
                if (animal.isAdopted == true)
                {
                    animals.Add(animal);
                }
            }
            return animals;
        }

        public List<Animal> GetAnimalsByAdopter(int id)
        {
            List<Animal> animals = new List<Animal>();
            foreach(Animal animal in GetAnimals())
            {
                if(animal.isAdopted == true && id == animal.adopter_id)
                {
                    animals.Add(animal);
                }
            }
            return animals;
        }

        public List<Animal> GetSpecies(Species species)
        {
            return datasource.GetAnimalBySpecies(species);
        }

        public List<Animal> GetNonAdoptedSpecies(Species species)
        {
            List<Animal> animals = new List<Animal>();
            foreach(Animal animal in GetSpecies(species))
            {
                if (animal.isAdopted == false)
                {
                    animals.Add(animal);
                }
            }
            return animals;
        }

        public List<Animal> GetSpeciesByAdopter(Species species, int id)
        {
            List<Animal> animals = new List<Animal>();
            foreach (Animal animal in GetSpecies(species))
            {
                if(animal.isAdopted == true && id == animal.adopter_id)
                {
                    animals.Add(animal);
                }
            }
            return animals;
        }

        public Animal GetAnimalById(int id)
        {
            return datasource.GetAnimalByID(id);
        }

        public void UpdateAnimal(Animal a)
        {
            datasource.UpdateAnimal(a);
        }

        public void DeleteAnimal(Animal a)
        {
            datasource.DeleteAnimal(a);
        }

        public void DeleteByID(int id)
        {
            datasource.DeleteAnimal(GetAnimalById(id));
        }
    }
}
