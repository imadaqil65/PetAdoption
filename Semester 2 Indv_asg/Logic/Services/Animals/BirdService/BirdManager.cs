using System;
using Domain.Animals;
using Domain.enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services.Animals.BirdService
{
	public class BirdManager
	{
		IBirdDB datasource;
		public BirdManager(IBirdDB datasource)
		{
			this.datasource = datasource;
		}

		public void CreateBird(Bird b)
		{
			datasource.CreateBird(b);
		}

		public void DeleteBird(Bird b)
		{
			datasource.DeleteBird(b);
		}

		public Bird GetBirdByID(int id)
		{
			return datasource.GetBirdByID(id);
		}

        public List<Bird> ReadAllBirds()
        {
            return datasource.ReadAllBirds();
        }

        public List<Bird> GetBirds()
		{
			List<Bird> NotAdoptedBirds = new List<Bird>();
			foreach(Bird bird in ReadAllBirds())
			{
				if (bird.isAdopted == false)
				{
					NotAdoptedBirds.Add(bird);
				}
			}
			return NotAdoptedBirds;
		}

		public void UpdateBird(Bird b)
		{
			datasource.UpdateBird(b);
		}
	}
}
