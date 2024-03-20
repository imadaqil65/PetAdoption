using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals.CatService;
using Semester_2_Unit_Test.FakeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_2_Unit_Test
{
    [TestClass]
    public class CatManagerTest
    {
        private CatManager catManager;
        private FakeCatDB fakeCatDB;

        public CatManagerTest()
        {
            fakeCatDB = new FakeCatDB();
            catManager = new CatManager(fakeCatDB);
        }

        [TestMethod]
        public void CreateCat()
        {
            Cat cat = new Cat("Lili", 2, Species.cat, 3, Gender.female, "shorthair", "calico", "-", true, null, "-");
            cat.id = 1;
            catManager.NewCat(cat);

            Assert.IsTrue(fakeCatDB.cats.Contains(cat));
        }

        [TestMethod]
        public void CreateCat_CatNotAdded()
        {
            Cat cat = new Cat("Lili", 2, Species.cat, 3, Gender.female, "shorthair", "calico", "-", true, null, "-");
            Cat cat2 = new Cat("Lala", 2, Species.cat, 3, Gender.male, "sphynx", "white", "-", true, null, "-");
            catManager.NewCat(cat);

            Assert.IsFalse(fakeCatDB.cats.Contains(cat2));
        }

        [TestMethod]
        public void ReadAllCats()
        {
            Cat cat = new Cat("Lili", 2, Species.cat, 3, Gender.female, "shorthair", "calico", "-", true, null, "-");
            Cat cat2 = new Cat("Lala", 2, Species.cat, 3, Gender.male, "sphynx", "white", "-", true, null, "-");
            catManager.NewCat(cat);
            catManager.NewCat(cat2);

            List<Cat> cats = catManager.GetAllCats();
            Assert.AreEqual(2, cats.Count);
        }

        [TestMethod]
        public void ReadAllCats_NoCatsinDatabase()
        {
            Cat cat = new Cat("Lili", 2, Species.cat, 3, Gender.female, "shorthair", "calico", "-", true, null, "-");
            Cat cat2 = new Cat("Lala", 2, Species.cat, 3, Gender.male, "sphynx", "white", "-", true, null, "-");

            List<Cat> cats = catManager.GetAllCats();
            Assert.AreNotEqual(2, cats.Count);
        }

        [TestMethod]
        public void ReadAllNonAdoptedCats()
        {
            Cat cat = new Cat(null, false, 1, "Lili", 2, "Wageningen", Species.cat, 3, Gender.female, "shorthair", "calico", "-", true, null, "-");
            Cat cat2 = new Cat(10, true, 2, "Lala", 2, "Wageningen", Species.cat, 3, Gender.male, "sphynx", "white", "-", true, null, "-");
            catManager.NewCat(cat);
            catManager.NewCat(cat2);

            List<Cat> cats = catManager.GetCats();
            Assert.AreEqual(1, cats.Count);
        }

        [TestMethod]
        public void ReadAllNonAdoptedCats_AllCatsAdopted()
        {
            Cat cat = new Cat(13, true, 1, "Lili", 2, "Wageningen", Species.cat, 3, Gender.female, "shorthair", "calico", "-", true, null, "-");
            Cat cat2 = new Cat(10, true, 2, "Lala", 2, "Wageningen", Species.cat, 3, Gender.male, "sphynx", "white", "-", true, null, "-");
            catManager.NewCat(cat);
            catManager.NewCat(cat2);

            List<Cat> cats = catManager.GetCats();
            Assert.AreNotEqual(1, cats.Count);
        }

        [TestMethod]
        public void GetByID()
        {
            Cat cat = new Cat(13, true, 1, "Lili", 2, "Wageningen", Species.cat, 3, Gender.female, "shorthair", "calico", "-", true, null, "-");
            Cat cat2 = new Cat(10, true, 2, "Lala", 2, "Wageningen", Species.cat, 3, Gender.male, "sphynx", "white", "-", true, null, "-");
            catManager.NewCat(cat);
            catManager.NewCat(cat2);

            Assert.AreEqual(cat, catManager.GetCat(1));
        }

        [TestMethod]
        public void GetByID_NoIDFound()
        {
            Cat cat = new Cat(13, true, 1, "Lili", 2, "Wageningen", Species.cat, 3, Gender.female, "shorthair", "calico", "-", true, null, "-");
            Cat cat2 = new Cat(10, true, 2, "Lala", 2, "Wageningen", Species.cat, 3, Gender.male, "sphynx", "white", "-", true, null, "-");
            catManager.NewCat(cat);
            catManager.NewCat(cat2);

            Assert.IsNull(catManager.GetCat(3));
        }

        [TestMethod]
        public void UpdateCat()
        {
            Cat cat = new Cat(null, false, 1, "Lili", 2, "Wageningen", Species.cat, 3, Gender.female, "shorthair", "calico", "-", true, null, "-");
            catManager.NewCat(cat);

            cat.name = "Avicii";

            catManager.UpdateCat(cat);
            Assert.AreEqual("Avicii", catManager.GetCat(1).name);
        }

        [TestMethod]
        public void UpdateCat_ExpectedOldName()
        {
            Cat cat = new Cat(null, false, 1, "Lili", 2, "Wageningen", Species.cat, 3, Gender.female, "shorthair", "calico", "-", true, null, "-");
            catManager.NewCat(cat);

            cat.name = "Avicii";

            catManager.UpdateCat(cat);
            Assert.AreNotEqual("Lili", catManager.GetCat(1).name);
        }

        [TestMethod]
        public void DeleteCat()
        {
            Cat cat = new Cat(13, true, 1, "Lili", 2, "Wageningen", Species.cat, 3, Gender.female, "shorthair", "calico", "-", true, null, "-");
            Cat cat2 = new Cat(10, true, 2, "Lala", 2, "Wageningen", Species.cat, 3, Gender.male, "sphynx", "white", "-", true, null, "-");
            catManager.NewCat(cat);
            catManager.NewCat(cat2);

            catManager.DeleteCat(cat);
            catManager.DeleteCat(cat2);
            Assert.IsTrue(!fakeCatDB.cats.Contains(cat));
            Assert.IsTrue(!fakeCatDB.cats.Contains(cat2));
        }

        [TestMethod]
        public void DeleteCat_CatNeverInTheDatabase()
        {
            Cat cat = new Cat(13, true, 1, "Lili", 2, "Wageningen", Species.cat, 3, Gender.female, "shorthair", "calico", "-", true, null, "-");
            Cat cat2 = new Cat(10, true, 2, "Lala", 2, "Wageningen", Species.cat, 3, Gender.male, "sphynx", "white", "-", true, null, "-");
            catManager.NewCat(cat);

            catManager.DeleteCat(cat2);
            Assert.IsFalse(!fakeCatDB.cats.Contains(cat));
        }
    }
}
