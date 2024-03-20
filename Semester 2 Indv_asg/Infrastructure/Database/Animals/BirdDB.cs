using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals.BirdService;
using MySql.Data.MySqlClient;

namespace Repository.Database.Animals
{
	public class BirdDB : IBirdDB
	{
		Connection connection = new Connection();

		public Connection Connection
		{
			get => default;
			set
			{
			}
		}

		public void CreateBird(Bird b)
		{
			using (MySqlConnection conn = connection.GetConnection())
			{
				string command = "INSERT INTO `s2_animals` (`Name`, `species_id`, `shelter_id`, `age`, `Gender`, `Description`, `Image_link`) VALUES (@Name, @Species, @Shelter, @age, @Gender, @Desc, 'img/Animals/AIBird.jpg');SELECT LAST_INSERT_ID()";
				string command2 = "INSERT INTO `s2_bird` (`Animal_id`, `breed`, `voice_mimic`, `wingspan`, `activitylevel` ) VALUES (@id, @breed, @voice, @wings, @active)";
				MySqlCommand add = new MySqlCommand(command, conn);
				try
				{
					add.Parameters.AddWithValue("@Name", b.name);
					add.Parameters.AddWithValue("@Species", b.species);
					add.Parameters.AddWithValue("@Shelter", b.shelterid);
					add.Parameters.AddWithValue("@Gender", b.gender);
					add.Parameters.AddWithValue("@age", b.age);
					add.Parameters.AddWithValue("@Desc", b.activityLevel);
					add.ExecuteNonQuery();
					int animalID = int.Parse(add.ExecuteScalar().ToString());
					MySqlCommand add2 = new MySqlCommand(command2, conn);
					add2.Parameters.AddWithValue("@id", animalID);
					add2.Parameters.AddWithValue("@breed", b.breed);
					add2.Parameters.AddWithValue("@voice", b.voicemimic);
					add2.Parameters.AddWithValue("@wings", b.wingspan);
					add2.Parameters.AddWithValue("@active", b.activityLevel);
					add2.ExecuteNonQuery();
				}
				catch { }

			}

		}

		public void DeleteBird(Bird b)
		{
			using (MySqlConnection conn = connection.GetConnection())
			{
				string command = "DELETE FROM `s2_animals` WHERE `Animal_id`=@id";
				MySqlCommand delete = new MySqlCommand(command, conn);
				try
				{
					delete.Parameters.AddWithValue("@id", b.id);
					delete.ExecuteNonQuery();
				}
				catch { }
			}
		}

		public Bird GetBirdByID(int id)
		{
			using (MySqlConnection conn = connection.GetConnection())
			{
				Bird bird = null;
				string command = "SELECT a.*, b.*, s.shelter_name, s.location, s.shelter_address FROM `s2_animals` as a INNER JOIN `s2_shelters` as s ON " +
					"a.shelter_id = s.shelter_id INNER JOIN `s2_bird` as b ON a.Animal_id = b.Animal_id WHERE `Animal_id` = @id";

				MySqlCommand add = new MySqlCommand(command, conn);
				try
				{

					add.Parameters.AddWithValue("@id", id);
					MySqlDataReader reader = add.ExecuteReader();
					while (reader.Read())
					{
						int? Adopter; if (!reader.IsDBNull(reader.GetOrdinal("Adopter_id")))
						{ Adopter = reader.GetInt32("Adopter_id"); }
						else { Adopter = null; }
						bool isAdopted = reader.GetBoolean("adopted_bool");
						int Animal_id = reader.GetInt32("Animal_id");
						string name = reader.GetString("Name");
						Species species = (Species)reader.GetInt32("species_id");
						int shelterid = reader.GetInt32("shelter_id");
						string shelter = reader.GetString("shelter_name");
						Gender gender = (Gender)reader.GetInt32("Gender");
						int age = reader.GetInt32("age");
						string images = reader.GetString("Image_link");
						string? desc; if (!reader.IsDBNull(reader.GetOrdinal("description")))
						{ desc = reader.GetString("Description"); }
						else { desc = null; }
						string breed = reader.GetString("breed");
						bool voice = reader.GetBoolean("voice_mimic");
						int wings = reader.GetInt32("wingspan");
						ActivityLevel active = (ActivityLevel)reader.GetInt32("activitylevel");
						bird = new Bird(Adopter, isAdopted, Animal_id, name, shelterid, shelter, species, age, gender, breed, voice, wings, active, desc, images);
					}

				}
				catch { }
				return bird;
			}
		}

		public List<Bird> ReadAllBirds()
		{
			using (MySqlConnection conn = connection.GetConnection())
			{
				List<Bird> birds = new List<Bird>();
				string command = "SELECT a.*, b.*, s.shelter_name, s.location, s.shelter_address FROM `s2_animals` as a INNER JOIN `s2_shelters` as s ON " +
					"a.shelter_id = s.shelter_id INNER JOIN `s2_bird` as b ON a.Animal_id = b.Animal_id";
				MySqlCommand add = new MySqlCommand(command, conn);
				try
				{
					MySqlDataReader reader = add.ExecuteReader();
					while (reader.Read())
					{
						int? Adopter; if (!reader.IsDBNull(reader.GetOrdinal("Adopter_id")))
						{ Adopter = reader.GetInt32("Adopter_id"); }
						else { Adopter = null; }
						bool isAdopted = reader.GetBoolean("adopted_bool");
						int Animal_id = reader.GetInt32("Animal_id");
						string name = reader.GetString("Name");
						Species species = (Species)reader.GetInt32("species_id");
						int shelterid = reader.GetInt32("shelter_id");
						string shelter = reader.GetString("shelter_name");
						Gender gender = (Gender)reader.GetInt32("Gender");
						int age = reader.GetInt32("age");
						string images = reader.GetString("Image_link");
						string? desc; if (!reader.IsDBNull(reader.GetOrdinal("description")))
						{ desc = reader.GetString("Description"); }
						else { desc = null; }
						string breed = reader.GetString("breed");
						bool voice = reader.GetBoolean("voice_mimic");
						int wings = reader.GetInt32("wingspan");
						ActivityLevel active = (ActivityLevel)reader.GetInt32("activitylevel");
						birds.Add(new Bird(Adopter, isAdopted, Animal_id, name, shelterid, shelter, species, age, gender, breed, voice, wings, active, desc, images));
					}
				}
				catch { }
				return birds;
			}
		}

		public void UpdateBird(Bird b)
		{
			string command = "UPDATE `s2_animals` SET `shelter_id`=@shelter, `Name`=@name, `age`=@age, `Gender`=@gender, `Description`=@description, `Adopter_id`=@adopter, `adopted_bool`=@adoptbool WHERE `Animal_id` = @id";
			string command2 = "UPDATE `s2_bird` SET  `breed`=@breed, `voice_mimic`=@voice, `wingspan`=@wings, `activitylevel`=@active WHERE `Animal_id`=@id";

			using (MySqlConnection conn = connection.GetConnection())
			{
				MySqlCommand add = new MySqlCommand(command, conn);
				try
				{
					add.Parameters.AddWithValue("@id", b.id);
					add.Parameters.AddWithValue("@shelter", b.shelterid);
					add.Parameters.AddWithValue("@name", b.name);
					add.Parameters.AddWithValue("@age", b.age);
					add.Parameters.AddWithValue("@gender", b.gender);
					add.Parameters.AddWithValue("@description", b.description);
					add.Parameters.AddWithValue("@adopter", b.adopter_id);
					add.Parameters.AddWithValue("@adoptbool", b.isAdopted);
					add.ExecuteNonQuery();
					MySqlCommand add2 = new MySqlCommand(command2, conn);
					add2.Parameters.AddWithValue("@id", b.id);
					add2.Parameters.AddWithValue("@breed", b.breed);
					add2.Parameters.AddWithValue("@voice", b.voicemimic);
					add2.Parameters.AddWithValue("@wings", b.wingspan);
					add2.Parameters.AddWithValue("@active", b.activityLevel);
					add2.ExecuteNonQuery();
				}
				catch { }
			}
		}
	}
}
