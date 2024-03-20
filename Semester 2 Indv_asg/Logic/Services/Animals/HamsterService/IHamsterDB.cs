using System;
using Domain.Animals;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services.Animals.HamsterService
{
	public interface IHamsterDB
	{
        public void CreateHamster(Hamster h);
        public void UpdateHamster(Hamster h);
        public void DeleteHamster(Hamster h);
        public List<Hamster> ReadAllDogs();
        public Hamster GetHamsterByID(int id);
    }
}
