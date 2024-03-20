using Domain.Adoption;
using Logic.Services.Adoption;
using Semester_2_Unit_Test.FakeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_2_Unit_Test
{
    [TestClass]
    public class AdoptionManagerTest
    {
        private FakeAdoptionDB fakeAdoptionDB;
        private PendingAdoptionManager AdoptionManager;

        public AdoptionManagerTest()
        {
            fakeAdoptionDB = new FakeAdoptionDB();
            AdoptionManager = new PendingAdoptionManager(fakeAdoptionDB);
        }

        [TestMethod]
        public void CreateAdoptionRequest()
        {
            var v = new PendingAdoption(1, 10, 7);
            AdoptionManager.NewAdoptionRequest(v);

            Assert.IsTrue(fakeAdoptionDB.adoptions.Contains(v));
        }

        [TestMethod]
        public void CreateAdoptionRequest_RequestNotAdded()
        {
            var v = new PendingAdoption(1, 10, 7);
            var v2 = new PendingAdoption(2, 9, 7);
            AdoptionManager.NewAdoptionRequest(v);

            Assert.IsFalse(fakeAdoptionDB.adoptions.Contains(v2));
        }

        [TestMethod]
        public void ReadAllRequests()
        {
            var v = new PendingAdoption(1, 10, 7);
            var v2 = new PendingAdoption(2, 9, 7);
            AdoptionManager.NewAdoptionRequest(v);
            AdoptionManager.NewAdoptionRequest(v2);

            List<PendingAdoption> requests = AdoptionManager.GetAdoptionRequests();
            Assert.IsNotNull(requests);
            CollectionAssert.AreEqual(new List<PendingAdoption> { v, v2 }, requests);
        }

        [TestMethod]
        public void ReadAllRequests_NoRequests()
        {
            var v = new PendingAdoption(1, 10, 7);
            var v2 = new PendingAdoption(2, 9, 7);

            List<PendingAdoption> requests = AdoptionManager.GetAdoptionRequests();
            CollectionAssert.AreNotEqual(new List<PendingAdoption> { v, v2 }, requests);
        }

        [TestMethod]
        public void GetByID()
        {
            var v = new PendingAdoption(1, 10, 7);
            var v2 = new PendingAdoption(2, 9, 7);
            AdoptionManager.NewAdoptionRequest(v);
            AdoptionManager.NewAdoptionRequest(v2);

            Assert.AreEqual(v, AdoptionManager.GetAdoptionRequestsByID(1));
        }

        [TestMethod]
        public void GetByID_NotInDatabase()
        {
            var v = new PendingAdoption(1, 10, 7);
            var v2 = new PendingAdoption(2, 9, 7);

            Assert.IsNull(AdoptionManager.GetAdoptionRequestsByID(1));
        }
        [TestMethod]
        public void DeleteRequests()
        {
            var v = new PendingAdoption(1, 10, 7);
            var v2 = new PendingAdoption(2, 9, 7);
            AdoptionManager.NewAdoptionRequest(v);
            AdoptionManager.NewAdoptionRequest(v2);

            AdoptionManager.DeleteAdoptionRequest(v);
            Assert.IsNull(AdoptionManager.GetAdoptionRequestsByID(1));
        }
        [TestMethod]
        public void DeleteRequests_DeletedWrongRequest()
        {
            var v = new PendingAdoption(1, 10, 7);
            var v2 = new PendingAdoption(2, 9, 7);
            AdoptionManager.NewAdoptionRequest(v);
            AdoptionManager.NewAdoptionRequest(v2);

            AdoptionManager.DeleteAdoptionRequest(v);
            Assert.IsNotNull(AdoptionManager.GetAdoptionRequestsByID(2));
        }
        [TestMethod]
        public void ApproveRequest()
        {
            var v = new PendingAdoption(1, 10, 7);
            var v2 = new PendingAdoption(2, 9, 7);
            AdoptionManager.NewAdoptionRequest(v);
            AdoptionManager.NewAdoptionRequest(v2);

            AdoptionManager.ApproveRequest(v);
            Assert.AreEqual(0,AdoptionManager.GetAdoptionRequests().Count);
        }
        [TestMethod]
        public void ApproveRequest_DifferentAnimal()
        {
            var v = new PendingAdoption(1, 10, 7);
            var v2 = new PendingAdoption(2, 9, 8);
            AdoptionManager.NewAdoptionRequest(v);
            AdoptionManager.NewAdoptionRequest(v2);

            AdoptionManager.ApproveRequest(v);
            Assert.IsNotNull(AdoptionManager.GetAdoptionRequests());
            Assert.IsTrue(fakeAdoptionDB.adoptions.Contains(v2));
        }
    }
}
