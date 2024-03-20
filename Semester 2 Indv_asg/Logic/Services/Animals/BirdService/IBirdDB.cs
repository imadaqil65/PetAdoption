using System;
using Domain.Animals;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services.Animals.BirdService
{
	public interface IBirdDB
	{
        public void CreateBird(Bird b);
        public void UpdateBird(Bird b);
        public void DeleteBird(Bird b);
        public List<Bird> ReadAllBirds();
        public Bird GetBirdByID(int id);
    }
}
