using MySql.Data.MySqlClient;
using Logic.Services.Animals;
using Domain.Animals;
using Domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Services.Animals.HamsterService;

namespace Repository.Database.Animals
{
	public class HamsterDB : IHamsterDB
	{
		Connection connection = new Connection();

		// -- HamsterDB not Implemented yet -- //

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
