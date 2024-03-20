using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals.CatService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_2_Unit_Test.FakeRepo
{
    public class FakeCatDB:ICatDB
    {
        public List<Cat> cats { get; }

        public FakeCatDB()
        {
            cats = new List<Cat>();
        }

        public void CreateCat(Cat c)
        {
            cats.Add(c);
        }

        public void UpdateCat(Cat c)
        {
            cats[c.id - 1] = c; ;
        }

        public void DeleteCat(Cat c)
        {
            cats.Remove(c);
        }

        public List<Cat> ReadAllCats()
        {
            return cats;
        }

        public Cat GetCatByID(int id)
        {
            foreach(Cat cat in cats)
            {
                if (cat.id == id)
                {
                    return cat;
                }
            };
            return null;
        }
    }
}
