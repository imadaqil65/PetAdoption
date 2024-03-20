using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals;
using Semester_2_Unit_Test.FakeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_2_Unit_Test
{
    [TestClass]
    public class AnimalManagerTest
    {
        private AnimalManager animalManager;
        private FakeAnimalDB fakeAnimalDB;

        public AnimalManagerTest()
        {
            fakeAnimalDB = new FakeAnimalDB();
            animalManager = new AnimalManager(fakeAnimalDB);
        }

        [TestMethod]
        public void CreateAnimal()
        {
            Animal a = new Animal("Alee", 2, Species.cat, 2, Gender.male, "none", "-");
            animalManager.CreateAnimal(a);

            Assert.IsTrue(fakeAnimalDB.animals.Contains(a));
        }

        [TestMethod]
        public void CreateAnimal_AnimalNotAddedToRepository()
        {
            Animal a = new Animal("Alee", 2, Species.cat, 2, Gender.male, "none", "-");

            Assert.IsFalse(fakeAnimalDB.animals.Contains(a));
        }

        [TestMethod]
        public void GetAnimalById()
        {
            Animal a = new Animal(1, "Leyla", 2, "Utrecht", Species.cat, 4, Gender.female, "none", "-");
            animalManager.CreateAnimal(a);

            Assert.AreEqual(a, animalManager.GetAnimalById(1));
        }

        [TestMethod]
        public void GetAnimalById_IdDoesNotExist()
        {
            Assert.IsFalse(fakeAnimalDB.animals.Contains(animalManager.GetAnimalById(1)));
        }

        [TestMethod]
        public void GetBySpecies()
        {
            Animal a1 = new Animal(1, "Alee", 2, "Brabantse", Species.cat, 2, Gender.male, "none", "-");
            Animal a2 = new Animal(2, "Leyla", 1, "Utrecht", Species.dog, 4, Gender.female, "none", "-");
            animalManager.CreateAnimal(a1);
            animalManager.CreateAnimal(a2);

            Assert.AreEqual(1, animalManager.GetSpecies(Species.cat).Count());
        }

        [TestMethod]
        public void GetBySpecies_AnimalWithTheSpecifiedSpeciesDoNotExist()
        {
            Animal a1 = new Animal(1, "Alee", 2, "Brabantse", Species.cat, 2, Gender.male, "none", "-");
            Animal a2 = new Animal(2, "Leyla", 1, "Utrecht", Species.dog, 4, Gender.female, "none", "-");
            animalManager.CreateAnimal(a1);
            animalManager.CreateAnimal(a2);

            Assert.AreNotEqual(1, animalManager.GetSpecies(Species.bird).Count());
        }

        [TestMethod]
        public void GetAllAnimals()
        {
            Animal a1 = new Animal(1, "Alee", 2, "Brabantse", Species.cat, 2, Gender.male, "none", "-");
            Animal a2 = new Animal(2, "Leyla", 1, "Utrecht", Species.dog, 4, Gender.female, "none", "-");
            animalManager.CreateAnimal(a1);
            animalManager.CreateAnimal(a2);

            List<Animal> animals = animalManager.GetAnimals();

            Assert.AreEqual(2, animals.Count());
            CollectionAssert.AreEqual(new List<Animal> { a1, a2 }, animals);
        }

        [TestMethod]
        public void GetAllAnimals_AnimalNotAddedToRepository()
        {
            Animal a1 = new Animal(1, "Alee", 1, "Brabantse", Species.cat, 2, Gender.male, "none", "-");
            Animal a2 = new Animal(2, "Leyla", 2, "Utrecht", Species.dog, 4, Gender.female, "none", "-");

            List<Animal> animals = animalManager.GetAnimals();

            Assert.AreNotEqual(2, animals.Count());
            CollectionAssert.AreNotEqual(new List<Animal> { a1, a2 }, animals);
        }

        [TestMethod]
        public void EditAnimal()
        {
            Animal a = new Animal(1, "Alee", 2, "Brabantse", Species.cat, 2, Gender.male, "none", "-");
            animalManager.CreateAnimal(a);

            a.id = 1;
            a.name = "Alee";
            a.shelter = "Belgium";
            a.species = Species.cat;
            a.age = 3;
            a.gender = Gender.male;
            a.description = "none";
            a.imagelink = "-";

            animalManager.UpdateAnimal(a);

            Assert.AreEqual("Belgium", animalManager.GetAnimalById(1).shelter);
        }

        [TestMethod]
        public void EditAnimal_AnimalAlreadyEdited()
        {
            Animal a = new Animal(1, "Alee", 2, "Brabantse", Species.cat, 2, Gender.male, "none", "-");
            animalManager.CreateAnimal(a);

            a.id = 1;
            a.name = "Alee";
            a.shelter = "Belgium";
            a.species = Species.cat;
            a.age = 3;
            a.gender = Gender.male;
            a.description = "none";
            a.imagelink = "-";

            animalManager.UpdateAnimal(a);

            Assert.AreNotEqual("Brabantse", animalManager.GetAnimalById(1).shelter);
        }

        [TestMethod]
        public void DeleteAnimal()
        {
            Animal a = new Animal("Alee", 2, Species.cat, 2, Gender.male, "none", "-");
            animalManager.CreateAnimal(a);
            animalManager.DeleteAnimal(a);

            Assert.IsTrue(!fakeAnimalDB.animals.Contains(a));
        }

        [TestMethod]
        public void DeleteAnimal_DeletedWrongAnimal()
        {
            Animal a1 = new Animal("Alee", 2, Species.cat, 2, Gender.male, "none", "-");
            Animal a2 = new Animal(2, "Leyla", 2, "Utrecht", Species.dog, 4, Gender.female, "none", "-");
            animalManager.CreateAnimal(a1);
            animalManager.DeleteAnimal(a2);

            Assert.IsFalse(!fakeAnimalDB.animals.Contains(a1));
        }

        [TestMethod]
        public void GetNonAdoptedAnimals()
        {
            Animal a = new Animal(10, true, 1, "name", 1, "Amsterdam", Species.cat, 8, Gender.female, "-", "-");
            Animal b = new Animal(2, "Leyla", 2, "Utrecht", Species.dog, 4, Gender.female, "none", "-");
            animalManager.CreateAnimal(a);
            animalManager.CreateAnimal(b);

            List<Animal> NonAdoptedAnimals = animalManager.GetNonAdoptedAnimals();
            Assert.AreEqual(1, NonAdoptedAnimals.Count());
        }

        [TestMethod]
        public void GetNonAdoptedAnimals_NoNonAdoptedAnimal()
        {
            Animal a = new Animal(10, true, 1, "name", 1, "Amsterdam", Species.cat, 8, Gender.female, "-", "-");
            animalManager.CreateAnimal(a);

            List<Animal> NonAdoptedAnimals = animalManager.GetNonAdoptedAnimals();
            Assert.AreNotEqual(1, NonAdoptedAnimals.Count());
        }

        [TestMethod]
        public void GetNonAdoptedAnimalsBySpecies()
        {
            Animal a = new Animal(10, true, 1, "name", 1, "Amsterdam", Species.dog, 8, Gender.female, "-", "-");
            Animal b = new Animal(2, "Leyla", 2, "Utrecht", Species.dog, 4, Gender.female, "none", "-");
            animalManager.CreateAnimal(a);
            animalManager.CreateAnimal(b);

            List<Animal> NonAdoptedDogs = animalManager.GetNonAdoptedSpecies(Species.dog);
            Assert.AreEqual(1, NonAdoptedDogs.Count());
        }

        [TestMethod]
        public void GetNonAdoptedAnimalsBySpecies_NoSelectedSpecies()
        {
            Animal a = new Animal(10, true, 1, "name", 1, "Amsterdam", Species.cat, 8, Gender.female, "-", "-");
            Animal b = new Animal(2, "Leyla", 2, "Utrecht", Species.bird, 4, Gender.female, "none", "-");
            animalManager.CreateAnimal(a);
            animalManager.CreateAnimal(b);

            List<Animal> NonAdoptedDogs = animalManager.GetNonAdoptedSpecies(Species.dog);
            Assert.AreNotEqual(1, NonAdoptedDogs.Count());
        }

        [TestMethod]
        public void GetAnimalsByAdopter()
        {
            Animal a = new Animal(10, true, 1, "name", 1, "Amsterdam", Species.dog, 8, Gender.female, "-", "-");
            Animal b = new Animal(10, true, 2, "orang", 1, "Amsterdam", Species.cat, 3, Gender.male, "-", "-");
            animalManager.CreateAnimal(a);
            animalManager.CreateAnimal(b);

            List<Animal> adoptedAnimals = animalManager.GetAnimalsByAdopter(10);
            Assert.AreEqual(2, adoptedAnimals.Count());
        }

        [TestMethod]
        public void GetAnimalsByAdopter_NoAdoptedAnimals()
        {
            Animal a = new Animal(8, true, 1, "name", 1, "Amsterdam", Species.dog, 8, Gender.female, "-", "-");
            Animal b = new Animal(12, true, 2, "orang", 1, "Amsterdam", Species.cat, 3, Gender.male, "-", "-");
            animalManager.CreateAnimal(a);
            animalManager.CreateAnimal(b);

            List<Animal> adoptedAnimals = animalManager.GetAnimalsByAdopter(10);
            Assert.AreNotEqual(2, adoptedAnimals.Count());
        }

        [TestMethod]
        public void GetSpeciesByAdopter()
        {
            Animal a = new Animal(10, true, 1, "name", 1, "Amsterdam", Species.dog, 8, Gender.female, "-", "-");
            Animal b = new Animal(2, "Leyla", 2, "Utrecht", Species.dog, 4, Gender.female, "none", "-");
            animalManager.CreateAnimal(a);
            animalManager.CreateAnimal(b);

            List<Animal> adoptedDogs = animalManager.GetSpeciesByAdopter(Species.dog, 10);
            Assert.AreEqual(1, adoptedDogs.Count());
        }

        [TestMethod]
        public void GetSpeciesByAdopter_NoSelectedSpecies()
        {
            Animal a = new Animal(10, true, 1, "name", 1, "Amsterdam", Species.dog, 8, Gender.female, "-", "-");
            Animal b = new Animal(2, "Leyla", 2, "Utrecht", Species.dog, 4, Gender.female, "none", "-");
            animalManager.CreateAnimal(a);
            animalManager.CreateAnimal(b);

            List<Animal> adoptedDogs = animalManager.GetSpeciesByAdopter(Species.cat, 10);
            Assert.AreNotEqual(1, adoptedDogs.Count());
        }

        [TestMethod]
        public void GetAdoptedAnimals()
        {
            Animal a = new Animal(8, true, 1, "name", 1, "Amsterdam", Species.dog, 8, Gender.female, "-", "-");
            Animal b = new Animal(12, true, 2, "orang", 1, "Amsterdam", Species.cat, 3, Gender.male, "-", "-");
            Animal c = new Animal(2, "Leyla", 2, "Utrecht", Species.dog, 4, Gender.female, "none", "-");
            animalManager.CreateAnimal(a);
            animalManager.CreateAnimal(b);
            animalManager.CreateAnimal(c);

            List<Animal> adoptedanimals = animalManager.GetAdoptedAnimals();
            Assert.IsNotNull(adoptedanimals);
        }

        [TestMethod]
        public void GetAdoptedAnimals_NoAdoptedAnimals()
        {
            Animal a1 = new Animal(1, "Alee", 2, "Brabantse", Species.cat, 2, Gender.male, "none", "-");
            Animal a2 = new Animal(2, "Leyla", 1, "Utrecht", Species.dog, 4, Gender.female, "none", "-");
            animalManager.CreateAnimal(a1);
            animalManager.CreateAnimal(a2);

            List<Animal> adoptedanimals = animalManager.GetAdoptedAnimals();
            Assert.AreNotEqual(2, adoptedanimals.Count);
        }
    }
}
