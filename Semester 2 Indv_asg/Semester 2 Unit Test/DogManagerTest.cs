using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals.CatService;
using Logic.Services.Animals.DogService;
using Semester_2_Unit_Test.FakeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_2_Unit_Test
{
    [TestClass]
    public class DogManagerTest
    {
        DogManager dogManager;
        FakeDogDB fakeDogDB;
        public DogManagerTest()
        {
            fakeDogDB = new FakeDogDB();
            dogManager = new DogManager(fakeDogDB);
        }
        [TestMethod]
        public void CreateDog()
        {
            Dog dog = new Dog("Lili", 2, Species.dog, 3, Gender.female, "Bulldog", true, true, ActivityLevel.medium, "-", "-");
            dog.id = 1;
            dogManager.NewDog(dog);

            Assert.IsTrue(fakeDogDB.dogs.Contains(dog));
        }

        [TestMethod]
        public void CreateDog_DogNotAdded()
        {
            Dog dog = new Dog("Lili", 2, Species.dog, 3, Gender.female, "Bulldog", true, true, ActivityLevel.medium, "-", "-");
            Dog dog2 = new Dog("Lala", 2, Species.dog, 3, Gender.male, "Terrier", true, true, ActivityLevel.medium, "-", "-");
            dogManager.NewDog(dog);

            Assert.IsFalse(fakeDogDB.dogs.Contains(dog2));
        }

        [TestMethod]
        public void ReadAllDogs()
        {
            Dog dog = new Dog("Lili", 2, Species.dog, 3, Gender.female, "Bulldog", true, true, ActivityLevel.medium, "-", "-");
            Dog dog2 = new Dog("Lala", 2, Species.dog, 3, Gender.male, "Terrier", true, true, ActivityLevel.medium, "-", "-");
            dogManager.NewDog(dog);
            dogManager.NewDog(dog2);

            List<Dog> dogs = dogManager.GetAllDogs();
            CollectionAssert.AreEqual(new List<Dog> {dog, dog2 }, dogs);
        }

        [TestMethod]
        public void ReadAllDogs_NoDogsinDatabase()
        {
            Dog dog = new Dog("Lili", 2, Species.dog, 3, Gender.female, "Bulldog", true, true, ActivityLevel.medium, "-", "-");
            Dog dog2 = new Dog("Lala", 2, Species.dog, 3, Gender.male, "Terrier", true, true, ActivityLevel.medium, "-", "-");

            List<Dog> dogs = dogManager.GetAllDogs();
            CollectionAssert.AreNotEqual(new List<Dog> { dog, dog2 }, dogs);
        }

        [TestMethod]
        public void ReadAllNonAdoptedDogs()
        {
            Dog dog = new Dog(10, true, 1, "Lili", 2, "Amsterdam", Species.dog, 3, Gender.female, "Bulldog", true, true, ActivityLevel.medium, "-", "-");
            Dog dog2 = new Dog(null, false, 2, "Lala", 2, "Groningen",Species.dog, 3, Gender.male, "Terrier", true, true, ActivityLevel.medium, "-", "-");
            dogManager.NewDog(dog);
            dogManager.NewDog(dog2);

            List<Dog> dogs = dogManager.GetDogs();
            CollectionAssert.AreEqual(new List<Dog> { dog2 }, dogs);
        }

        [TestMethod]
        public void ReadAllNonAdoptedDogs_AllDogsAdopted()
        {
            Dog dog = new Dog(10, true, 1, "Lili", 2, "Amsterdam", Species.dog, 3, Gender.female, "Bulldog", true, true, ActivityLevel.medium, "-", "-");
            Dog dog2 = new Dog(21, true, 2, "Lala", 2, "Groningen", Species.dog, 3, Gender.male, "Terrier", true, true, ActivityLevel.medium, "-", "-");
            dogManager.NewDog(dog);
            dogManager.NewDog(dog2);

            List<Dog> dogs = dogManager.GetDogs();
            Assert.AreEqual(0, dogs.Count);
        }

        [TestMethod]
        public void GetByID()
        {
            Dog dog = new Dog(10, true, 1, "Lili", 2, "Amsterdam", Species.dog, 3, Gender.female, "Bulldog", true, true, ActivityLevel.medium, "-", "-");
            Dog dog2 = new Dog(null, false, 2, "Lala", 2, "Groningen", Species.dog, 3, Gender.male, "Terrier", true, true, ActivityLevel.medium, "-", "-");
            dogManager.NewDog(dog);
            dogManager.NewDog(dog2);

            Assert.AreEqual(dog, dogManager.GetDog(1));
        }

        [TestMethod]
        public void GetByID_NoIDFound()
        {
            Dog dog = new Dog(10, true, 1, "Lili", 2, "Amsterdam", Species.dog, 3, Gender.female, "Bulldog", true, true, ActivityLevel.medium, "-", "-");
            Dog dog2 = new Dog(null, false, 2, "Lala", 2, "Groningen", Species.dog, 3, Gender.male, "Terrier", true, true, ActivityLevel.medium, "-", "-");
            dogManager.NewDog(dog);
            dogManager.NewDog(dog2);

            Assert.IsNull(dogManager.GetDog(3));
        }

        [TestMethod]
        public void UpdateDog()
        {
            Dog dog2 = new Dog(null, false, 1, "Lala", 2, "Groningen", Species.dog, 3, Gender.male, "Terrier", true, true, ActivityLevel.medium, "-", "-");
            dogManager.NewDog(dog2);
            dog2.name = "Avicii";

            dogManager.UpdateDog(dog2);
            Assert.AreEqual("Avicii", dogManager.GetDog(1).name);
        }

        [TestMethod]
        public void UpdateDog_ExpectedOldName()
        {
            Dog dog2 = new Dog(null, false, 1, "Lala", 2, "Groningen", Species.dog, 3, Gender.male, "Terrier", true, true, ActivityLevel.medium, "-", "-");
            dogManager.NewDog(dog2);
            dog2.name = "Avicii";

            dogManager.UpdateDog(dog2);
            Assert.AreNotEqual("Lala", dogManager.GetDog(1).name);
        }

        [TestMethod]
        public void DeleteDog()
        {
            Dog dog = new Dog(null, false, 1, "Lili", 2, "Amsterdam", Species.dog, 3, Gender.female, "Bulldog", true, true, ActivityLevel.medium, "-", "-");
            Dog dog2 = new Dog(null, false, 2, "Lala", 2, "Groningen", Species.dog, 3, Gender.male, "Terrier", true, true, ActivityLevel.medium, "-", "-");
            dogManager.NewDog(dog);
            dogManager.NewDog(dog2);

            dogManager.DeleteDog(dog);
            dogManager.DeleteDog(dog2); 
            Assert.IsTrue(!fakeDogDB.dogs.Contains(dog));
            Assert.IsTrue(!fakeDogDB.dogs.Contains(dog2));
        }

        [TestMethod]
        public void DeleteDog_DogNeverInTheDatabase()
        {
            Dog dog = new Dog(null, false, 1, "Lili", 2, "Amsterdam", Species.dog, 3, Gender.female, "Bulldog", true, true, ActivityLevel.medium, "-", "-");
            Dog dog2 = new Dog(null, false, 2, "Lala", 2, "Groningen", Species.dog, 3, Gender.male, "Terrier", true, true, ActivityLevel.medium, "-", "-");
            dogManager.NewDog(dog);

            dogManager.DeleteDog(dog2);
            Assert.IsTrue(!fakeDogDB.dogs.Contains(dog2));
        }
    }
}
