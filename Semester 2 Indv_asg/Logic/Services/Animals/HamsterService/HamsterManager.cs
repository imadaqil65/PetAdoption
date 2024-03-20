using Domain.Animals;

namespace Logic.Services.Animals.HamsterService
{
	public class HamsterManager
	{
		IHamsterDB datasource;
		public HamsterManager(IHamsterDB datasource)
		{
			this.datasource = datasource;
		}

		public void CreateHamster(Hamster h)
		{
			throw new NotImplementedException();
		}

		public void DeleteHamster(Hamster h)
		{
			throw new NotImplementedException();
		}

		public Hamster GetHamsterByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Hamster> ReadAllDogs()
		{
			throw new NotImplementedException();
		}

		public void UpdateHamster(Hamster h)
		{
			throw new NotImplementedException();
		}
	}
}
