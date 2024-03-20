using Domain.Shelters;
using Logic.Services.ShelterService;
using Semester_2_Unit_Test.FakeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_2_Unit_Test
{
    [TestClass]
    public class ShelterManagerTest
    {
        private FakeShelterDB fakeShelterDB;
        private ShelterManager shelterManager;

        public ShelterManagerTest()
        {
            fakeShelterDB = new FakeShelterDB();
            shelterManager = new ShelterManager(fakeShelterDB);
        }

        [TestMethod]
        public void CreateShelter()
        {
            Shelter shelter = new Shelter(1, "Anibus", "Amsterdam", "Amstelstraat 11");
            shelterManager.NewShelter(shelter);

            Assert.IsTrue(fakeShelterDB.shelters.Contains(shelter));
        }

        [TestMethod]
        public void CreateShelter_ShelterNotAdded()
        {
            Shelter shelter = new Shelter(1, "Anibus", "Amsterdam", "Amstelstraat 11");
            Shelter shelter2 = new Shelter(2, "Mumba", "Eindhoven", "Nikolastraat 92");
            shelterManager.NewShelter(shelter);

            Assert.IsFalse(fakeShelterDB.shelters.Contains(shelter2));
        }

        [TestMethod]
        public void ReadAllShelters()
        {
            Shelter shelter = new Shelter(1, "Anibus", "Amsterdam", "Amstelstraat 11");
            Shelter shelter2 = new Shelter(2, "Mumba", "Eindhoven", "Nikolastraat 92");
            shelterManager.NewShelter(shelter);
            shelterManager.NewShelter(shelter2);

            List<Shelter> Shelters = shelterManager.GetShelters();
            CollectionAssert.AreEqual(new List<Shelter> { shelter, shelter2 }, Shelters);
        }
        [TestMethod]
        public void ReadAllShelters_DatabaseEmpty()
        {
            Shelter shelter = new Shelter(1, "Anibus", "Amsterdam", "Amstelstraat 11");
            Shelter shelter2 = new Shelter(2, "Mumba", "Eindhoven", "Nikolastraat 92");

            List<Shelter> Shelters = shelterManager.GetShelters();
            CollectionAssert.AreNotEqual(new List<Shelter> { shelter, shelter2 }, Shelters);
        }
        [TestMethod]
        public void GetByID()
        {
            Shelter shelter = new Shelter(1, "Anibus", "Amsterdam", "Amstelstraat 11");
            Shelter shelter2 = new Shelter(2, "Mumba", "Eindhoven", "Nikolastraat 92");
            shelterManager.NewShelter(shelter);
            shelterManager.NewShelter(shelter2);

            Assert.AreEqual(shelter, shelterManager.GetShelterByID(1));
        }
        [TestMethod]
        public void GetByID_NotFound()
        {
            Shelter shelter = new Shelter(1, "Anibus", "Amsterdam", "Amstelstraat 11");
            Shelter shelter2 = new Shelter(2, "Mumba", "Eindhoven", "Nikolastraat 92");

            Assert.IsNull(shelterManager.GetShelterByID(1));
        }

        [TestMethod]
        public void UpdateShelter()
        {
            Shelter shelter = new Shelter(1, "Anibus", "Amsterdam", "Amstelstraat 11");
            shelterManager.NewShelter(shelter);

            shelter.name = "Bellita";
            shelterManager.UpdateShelter(shelter);

            Assert.AreEqual("Bellita", shelterManager.GetShelterByID(1).name);
        }

        [TestMethod]
        public void UpdateShelter_ExpectOldName()
        {
            Shelter shelter = new Shelter(1, "Anibus", "Amsterdam", "Amstelstraat 11");
            shelterManager.NewShelter(shelter);

            shelter.name = "Bellita";
            shelterManager.UpdateShelter(shelter);

            Assert.AreNotEqual("Anibus", shelterManager.GetShelterByID(1).name);
        }
        [TestMethod]
        public void DeleteShelter()
        {
            Shelter shelter = new Shelter(1, "Anibus", "Amsterdam", "Amstelstraat 11");
            Shelter shelter2 = new Shelter(2, "Mumba", "Eindhoven", "Nikolastraat 92");
            shelterManager.NewShelter(shelter);
            shelterManager.NewShelter(shelter2);

            shelterManager.DeleteShelter(shelter2);

            Assert.IsNull(shelterManager.GetShelterByID(2));
            Assert.IsTrue(fakeShelterDB.shelters.Contains(shelter));
        }

        [TestMethod]
        public void DeleteShelter_DeletedWrongShelter()
        {
            Shelter shelter = new Shelter(1, "Anibus", "Amsterdam", "Amstelstraat 11");
            Shelter shelter2 = new Shelter(2, "Mumba", "Eindhoven", "Nikolastraat 92");
            shelterManager.NewShelter(shelter);

            shelterManager.DeleteShelter(shelter2);

            Assert.IsFalse(!fakeShelterDB.shelters.Contains(shelter));
        }
    }
}
