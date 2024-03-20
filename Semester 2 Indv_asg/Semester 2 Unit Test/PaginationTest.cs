using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals;
using Logic.Services.PaginationAndFilter;
using Semester_2_Unit_Test.FakeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Semester_2_Unit_Test
{
    [TestClass]
    public class PaginationTest
    {
        private AnimalManager manager;
        private FakeAnimalDB db;
        public PaginationTest()
        {
            db = new FakeAnimalDB();
            manager = new AnimalManager(db);
        }

        public void Add_Fake_Animals()
        {
            Animal a1 = new Animal(1, "Alee", 3, "Brabantse", Species.cat, 2, Gender.male, "none", "-");
            Animal a2 = new Animal(2, "Leyla", 4, "Utrecht", Species.dog, 4, Gender.female, "none", "-");
            Animal a3 = new Animal(3, "Pedro", 5, "Zeeland", Species.bird, 3, Gender.female, "none", "-");
            Animal a4 = new Animal(4, "Hamtaro", 6, "Amsterdam", Species.hamster, 3, Gender.male, "none", "-");
            Animal a5 = new Animal(5, "anonym", 2, "Wageningen", Species.cat, 7, Gender.female, "none", "-");
            manager.CreateAnimal(a1);
            manager.CreateAnimal(a2);
            manager.CreateAnimal(a3);
            manager.CreateAnimal(a4);
            manager.CreateAnimal(a5);
        }

        #region Pagination Class Test

        [TestMethod]
        public void PaginationTesGetPage_ReturnsCorrectPage()
        {
            Add_Fake_Animals();
            List<Animal> data = manager.GetAnimals();
            Pagination<Animal> paginationHelper = new Pagination<Animal>(data, pageSize: 1);
            int pageIndex = 1;

            PaginatedList<Animal> result = paginationHelper.GetPage(pageIndex);

            Assert.AreEqual(pageIndex, result.PageIndex);
            Assert.AreEqual(5, result.TotalPages);
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void PaginationTesGetPage_ReturnsIncorrectPage()
        {
            Add_Fake_Animals();
            List<Animal> data = manager.GetAnimals();
            Pagination<Animal> paginationHelper = new Pagination<Animal>(data, pageSize: 1);
            int pageIndex = 6;

            PaginatedList<Animal> result = paginationHelper.GetPage(pageIndex);

            Assert.AreNotEqual(6, result.TotalPages);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void GetVisiblePageNumbers_MaxVisibleNumberIsCorrect()
        {
            Add_Fake_Animals();
            Pagination<Animal> paginationHelper = new Pagination<Animal>(manager.GetAnimals(), pageSize: 1);
            int pageIndex = 1;
            int totalPages = 5;
            int maxVisiblePages = 6;
            IEnumerable<int> result = paginationHelper.GetVisiblePageNumbers(pageIndex, totalPages, maxVisiblePages);

            Assert.AreEqual(5, result.Count());
        }

        [TestMethod]
        public void GetVisiblePageNumbers_MaxVisibleNumberIsIncorrect()
        {
            Add_Fake_Animals();
            Pagination<Animal> paginationHelper = new Pagination<Animal>(manager.GetAnimals(), pageSize: 1);
            int pageIndex = 1;
            int totalPages = 5;
            int maxVisiblePages = 3;
            IEnumerable<int> result = paginationHelper.GetVisiblePageNumbers(pageIndex, totalPages, maxVisiblePages);

            Assert.AreNotEqual(5, result.Count());
        }
        #endregion

        #region PaginatedList Test

        [TestMethod]
        public void Constructor_SetsProperties()
        {
            Add_Fake_Animals();
            List<Animal> items = manager.GetAnimals();
            int pageIndex = 1;
            int totalPages = 5;
            int totalItems = 5;
            PaginatedList<Animal> paginatedList = new PaginatedList<Animal>(items, pageIndex, totalPages, totalItems);

            CollectionAssert.AreEqual(items, paginatedList);
            Assert.AreEqual(pageIndex, paginatedList.PageIndex);
            Assert.AreEqual(totalPages, paginatedList.TotalPages);
            Assert.AreEqual(totalItems, paginatedList.TotalItems);
        }

        [TestMethod]
        public void Constructor_DoesNotSetsProperties()
        {
            Add_Fake_Animals();
            List<Animal> items = manager.GetAnimals();
            int pageIndex = 1;
            int totalPages = 5;
            int totalItems = 5;
            PaginatedList<Animal> paginatedList = new PaginatedList<Animal>(items, pageIndex, totalPages, totalItems);

            Assert.AreNotEqual(null, paginatedList);
            Assert.AreNotEqual(0, paginatedList.PageIndex);
            Assert.AreNotEqual(0, paginatedList.TotalPages);
            Assert.AreNotEqual(0, paginatedList.TotalItems);
        }

        [TestMethod]
        public void HasPreviousPage_ReturnsTrueWhenNotFirstPage()
        {
            Add_Fake_Animals();
            List<Animal> items = manager.GetAnimals();
            int pageIndex = 2;
            int totalPages = 5;
            int totalItems = 5;
            PaginatedList<Animal> paginatedList = new PaginatedList<Animal>(items, pageIndex, totalPages, totalItems);

            bool result = paginatedList.HasPreviousPage;

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasPreviousPage_ReturnsFalseWhenIsFirstPage()
        {
            Add_Fake_Animals();
            List<Animal> items = manager.GetAnimals();
            int pageIndex = 1;
            int totalPages = 5;
            int totalItems = 5;
            PaginatedList<Animal> paginatedList = new PaginatedList<Animal>(items, pageIndex, totalPages, totalItems);

            bool result = paginatedList.HasPreviousPage;

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasNextPage_ReturnsTrueWhenNotLastPage()
        {
            Add_Fake_Animals();
            List<Animal> items = manager.GetAnimals();
            int pageIndex = 1;
            int totalPages = 5;
            int totalItems = 5;
            PaginatedList<Animal> paginatedList = new PaginatedList<Animal>(items, pageIndex, totalPages, totalItems);

            bool result = paginatedList.HasNextPage;

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasNextPage_ReturnsFalseWhenIsLastPage()
        {
            Add_Fake_Animals();
            List<Animal> items = manager.GetAnimals();
            int pageIndex = 5;
            int totalPages = 5;
            int totalItems = 5;
            PaginatedList<Animal> paginatedList = new PaginatedList<Animal>(items, pageIndex, totalPages, totalItems);

            bool result = paginatedList.HasNextPage;

            Assert.IsFalse(result);
        }

        #endregion

        #region Filter Class
        [TestMethod]
        public void ApplyFilter()
        {
            Add_Fake_Animals();
            List<Animal> animals = manager.GetAnimals();
            Filter<Animal> filterHelper = new Filter<Animal>(animals);

            IEnumerable<Animal> result = filterHelper.ApplyFilter(a => a.name.ToLower().Contains("a"));

            Assert.AreEqual(4, result.Count());
        }

        [TestMethod]
        public void ApplyFilter_Failed()
        {
            Add_Fake_Animals();
            List<Animal> animals = manager.GetAnimals();
            Filter<Animal> filterHelper = new Filter<Animal>(animals);

            IEnumerable<Animal> result = filterHelper.ApplyFilter(a => a.name.ToLower().Contains("i"));

            Assert.AreNotEqual(4, result.Count());
        }
        #endregion
    }
}
