using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals;

namespace Semester_2_Unit_Test.FakeRepo
{
    public class FakeAnimalDB : IAnimalDB
    {
        public List<Animal> animals { get; }

        public FakeAnimalDB()
        {
            animals = new List<Animal>();
        }

        public void CreateAnimal(Animal a)
        {
            animals.Add(a);
        }

        public void DeleteAnimal(Animal a)
        {
            animals.Remove(a);
        }

        public Animal GetAnimalByID(int id)
        {
            foreach (Animal animal in animals)
            {
                if (id == animal.id)
                {
                    return animal;
                }
            }
            return null;
        }

        public List<Animal> GetAnimalBySpecies(Species species)
        {
            List<Animal> fakeanimals = new List<Animal>();
            foreach (Animal animal in animals)
            {
                if (species == animal.species)
                {
                    fakeanimals.Add(animal);
                }
            }
            return fakeanimals;
        }

        public List<Animal> ReadAllAnimals()
        {
            return animals;
        }

        public void UpdateAnimal(Animal a)
        {
            animals[a.id - 1] = a;
        }
    }
}
