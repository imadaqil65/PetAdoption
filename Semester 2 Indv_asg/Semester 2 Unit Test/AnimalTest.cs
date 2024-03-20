using Domain.Animals;
using Domain.enums;
namespace Semester_2_Unit_Test
{
    [TestClass]
    public class AnimalTest
    {
        [TestMethod]
        public void CheckConstructor1OfAnimal()
        {
            Animal a = new Animal("Alee", 2, Species.cat, 2, Gender.male, "none", "-");

            Assert.AreEqual("Alee", a.name);
            Assert.AreEqual(2,a.shelterid);
            Assert.AreEqual(Species.cat,a.species);
            Assert.AreEqual(2,a.age);
            Assert.AreEqual(Gender.male,a.gender);
            Assert.AreEqual("none",a.description);
            Assert.AreEqual("-",a.imagelink);
        }

        [TestMethod]
        public void CheckConstructor2OfAnimal()
        {
            Animal a = new Animal("Alee", "Amersfoort", Species.cat, 2, Gender.male, "none", "-");

            Assert.AreEqual("Alee", a.name);
            Assert.AreEqual("Amersfoort", a.shelter);
            Assert.AreEqual(Species.cat, a.species);
            Assert.AreEqual(2, a.age);
            Assert.AreEqual(Gender.male, a.gender);
            Assert.AreEqual("none", a.description);
            Assert.AreEqual("-", a.imagelink);
        }

        [TestMethod]
        public void CheckConstructor3OfAnimal()
        {
            Animal a = new Animal(1 ,"Alee", 3, "Amersfoort", Species.cat, 2, Gender.male, "none", "-");

            Assert.AreEqual(1, a.id);
            Assert.AreEqual("Alee", a.name);
            Assert.AreEqual(3, a.shelterid);
            Assert.AreEqual("Amersfoort", a.shelter);
            Assert.AreEqual(Species.cat, a.species);
            Assert.AreEqual(2, a.age);
            Assert.AreEqual(Gender.male, a.gender);
            Assert.AreEqual("none", a.description);
            Assert.AreEqual("-", a.imagelink);
        }

        public void CheckConstructor4OfAnimal()
        {
            Animal a = new Animal(1, true, 1, "name", 1, "Amsterdam", Species.cat, 8, Gender.female, "-", "-");

            Assert.AreEqual(1, a.adopter_id);
            Assert.IsTrue(a.isAdopted);
            Assert.AreEqual(1, a.id);
            Assert.AreEqual("name", a.name);
            Assert.AreEqual(3, a.shelterid);
            Assert.AreEqual("Amsterdam", a.shelter);
            Assert.AreEqual(Species.cat, a.species);
            Assert.AreEqual(8, a.age);
            Assert.AreEqual(Gender.female, a.gender);
            Assert.AreEqual("-", a.description);
            Assert.AreEqual("-", a.imagelink);
        }
    }
}