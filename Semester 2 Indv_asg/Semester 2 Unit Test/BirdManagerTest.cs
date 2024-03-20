using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals.BirdService;
using Semester_2_Unit_Test.FakeRepo;

namespace Semester_2_Unit_Test
{
    [TestClass]
    public class BirdManagerTest
    {
        FakeBirdDB fakeBirdDB;
        BirdManager birdManager;
        public BirdManagerTest()
        {
            fakeBirdDB = new FakeBirdDB();
            birdManager = new BirdManager(fakeBirdDB);
        }

        [TestMethod]
        public void CreateBird()
        {
            Bird bird = new Bird(null, false, 1, "pedro", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            birdManager.CreateBird(bird);

            Assert.IsTrue(fakeBirdDB.birds.Contains(bird));
        }

        [TestMethod]
        public void CreateBird_WrongBirdAdded()
        {
            Bird bird = new Bird(null, false, 1, "pedro", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            Bird bird2 = new Bird(null, false, 2, "pierre", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            birdManager.CreateBird(bird2);

            Assert.IsFalse(fakeBirdDB.birds.Contains(bird));
        }

        [TestMethod]
        public void ReadAllBirds()
        {
            Bird bird = new Bird(null, false, 1, "pedro", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            Bird bird2 = new Bird(null, false, 2, "pierre", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            birdManager.CreateBird(bird);
            birdManager.CreateBird(bird2);

            List<Bird> birds = birdManager.ReadAllBirds();
            CollectionAssert.AreEqual(new List<Bird> { bird, bird2 }, birds);
        }

        [TestMethod]
        public void ReadAllBirds_NoBirdsinDatabase()
        {
            Bird bird = new Bird(null, false, 1, "pedro", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            Bird bird2 = new Bird(null, false, 2, "pierre", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");

            List<Bird> birds = birdManager.ReadAllBirds();
            CollectionAssert.AreNotEqual(new List<Bird> { bird, bird2 }, birds);
        }

        [TestMethod]
        public void GetNonAdoptedBirds()
        {
            Bird bird = new Bird(10, true, 1, "pedro", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            Bird bird2 = new Bird(null, false, 2, "pierre", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            birdManager.CreateBird(bird);
            birdManager.CreateBird(bird2);

            List<Bird> birds = birdManager.GetBirds();
            CollectionAssert.AreEqual(new List<Bird> { bird2}, birds);
        }

        [TestMethod]
        public void GetNonAdoptedBirds_ALBirdsAdopted()
        {
            Bird bird = new Bird(10, true, 1, "pedro", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            Bird bird2 = new Bird(7, true, 2, "pierre", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            birdManager.CreateBird(bird);
            birdManager.CreateBird(bird2);

            List<Bird> birds = birdManager.GetBirds();
            Assert.AreNotEqual(2, birds.Count());
        }

        [TestMethod]
        public void GetByID()
        {
            Bird bird = new Bird(10, true, 1, "pedro", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            Bird bird2 = new Bird(null, false, 2, "pierre", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            birdManager.CreateBird(bird);
            birdManager.CreateBird(bird2);

            Assert.AreEqual(bird, birdManager.GetBirdByID(1));
        }

        [TestMethod]
        public void GetByID_NotFound()
        {
            Bird bird = new Bird(10, true, 1, "pedro", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            Bird bird2 = new Bird(null, false, 2, "pierre", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            birdManager.CreateBird(bird);
            birdManager.CreateBird(bird2);

            Assert.IsNull(birdManager.GetBirdByID(3));
        }

        [TestMethod]
        public void UpdateBird()
        {
            Bird bird = new Bird(10, true, 1, "pedro", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            birdManager.CreateBird(bird);
            bird.name = "Felina";

            birdManager.UpdateBird(bird);

            Assert.AreEqual("Felina", birdManager.GetBirdByID(1).name);
        }

        [TestMethod]
        public void UpdateBird_ExectOldName()
        {
            Bird bird = new Bird(10, true, 1, "pedro", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            birdManager.CreateBird(bird);
            bird.name = "Felina";

            birdManager.UpdateBird(bird);

            Assert.AreNotEqual("Pedro", birdManager.GetBirdByID(1).name);
        }

        [TestMethod]
        public void DeleteBird()
        {
            Bird bird = new Bird(10, true, 1, "pedro", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            Bird bird2 = new Bird(null, false, 2, "pierre", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            birdManager.CreateBird(bird);
            birdManager.CreateBird(bird2);

            birdManager.DeleteBird(bird);
            birdManager.DeleteBird(bird2);

            Assert.AreEqual(0, fakeBirdDB.birds.Count);
        }

        [TestMethod]
        public void DeleteBird_DeletedWrongBird()
        {
            Bird bird = new Bird(10, true, 1, "pedro", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            Bird bird2 = new Bird(null, false, 2, "pierre", 2, "Eindhoven", Species.bird, 3, Gender.male, "cockatoo", true, 98, ActivityLevel.low, "none", "-");
            birdManager.CreateBird(bird);
            
            birdManager.DeleteBird(bird2);

            Assert.IsFalse(!fakeBirdDB.birds.Contains(bird));
        }
    }
}
