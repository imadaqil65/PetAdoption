using System;
using Domain.Animals;
using Domain.enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services.Animals.CatService
{
    public class CatManager
    {
        ICatDB datasource;

        public CatManager(ICatDB datasource)
        {
            this.datasource = datasource;
        }

        public void NewCat(Cat cat)
        {
            datasource.CreateCat(cat);
        }

        public List<Cat> GetAllCats()
        {
            return datasource.ReadAllCats();
        }

        public List<Cat> GetCats()
        {
            List<Cat> cats = new List<Cat>();
            foreach (Cat c in GetAllCats())
            {
                if(c.isAdopted == false)
                cats.Add(c);
            }
            return cats;
        }

        public Cat GetCat(int id)
        {
            return datasource.GetCatByID(id);
        }

        public void UpdateCat(Cat c)
        {
            datasource.UpdateCat(c);
        }

        public void DeleteCat(Cat c)
        {
            datasource.DeleteCat(c);
        }


    }
}
