using System;
using Domain.Animals;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services.Animals.CatService
{
    public interface ICatDB
    {
        public void CreateCat(Cat c);
        public void UpdateCat(Cat c);
        public void DeleteCat(Cat c);
        public List<Cat> ReadAllCats();
        public Cat GetCatByID(int id);
    }
}
