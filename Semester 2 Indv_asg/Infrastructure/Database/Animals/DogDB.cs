using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals.DogService;
using MySql.Data.MySqlClient;

namespace Repository.Database.Animals
{
    public class DogDB : IDogDB
    {
        Connection connection = new Connection();

        public Connection Connection
        {
            get => default;
            set
            {
            }
        }

        public void CreateDog(Dog d)
        {
            string command = "INSERT INTO `s2_animals` (`Name`, `species_id`, `shelter_id`, `age`, `Gender`, `Description`, `Image_link`) VALUES " +
                " (@Name, @Species, @Shelter, @age, @Gender, @Desc, 'img/Animals/AIDog.jpg'); SELECT LAST_INSERT_ID();";
            string command2 = "INSERT INTO `s2_dog` (`Animal_id`, `breed`, `housetrained`, `IsSterile`, `activitylevel`) VALUES " +
                " (@Animal_id, @breed, @housetrained, @sterile, @active)";
            using (MySqlConnection conn = connection.GetConnection())
            {
                MySqlCommand add = new MySqlCommand(command, conn);
                try
                {

                    add.Parameters.AddWithValue("@Name", d.name);
                    add.Parameters.AddWithValue("@Species", d.species);
                    add.Parameters.AddWithValue("@Shelter", d.shelterid);
                    add.Parameters.AddWithValue("@Gender", d.gender);
                    add.Parameters.AddWithValue("@age", d.age);
                    add.Parameters.AddWithValue("@Desc", d.description);
                    int animalID = int.Parse(add.ExecuteScalar().ToString());

                    MySqlCommand addToTable = new MySqlCommand(command2, conn);
                    addToTable.Parameters.AddWithValue("@Animal_id", animalID);
                    addToTable.Parameters.AddWithValue("@breed", d.breed);
                    addToTable.Parameters.AddWithValue("@housetrained", d.housetrained);
                    addToTable.Parameters.AddWithValue("@sterile", d.sterile);
                    addToTable.Parameters.AddWithValue("@active", d.activityLevel);
                    addToTable.ExecuteNonQuery();
                }
                catch (Exception ex) /*Exception not implemented*/
                {
                    throw new Exception($"Cannot create entity\n{ex.Message}");
                }
            }
        }

        public void DeleteDog(Dog d)
        {
            string command = "DELETE FROM `s2_animals` WHERE `Animal_id` = @id";
            using (MySqlConnection conn = connection.GetConnection())
            {
                MySqlCommand add = new MySqlCommand(command, conn);
                try
                {

                    add.Parameters.AddWithValue("@id", d.id);
                    MySqlDataReader reader = add.ExecuteReader();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public Dog GetDogByID(int id)
        {

            string command = "SELECT a.*, s.shelter_name, s.location, s.shelter_address, d.breed, d.housetrained, d.IsSterile, d.activityLevel " +
                "FROM `s2_animals` as a INNER JOIN `s2_dog` as d ON a.Animal_id = d.Animal_id INNER JOIN `s2_shelters` as s ON a.shelter_id = s.shelter_id WHERE a.Animal_id = @id";
            using (MySqlConnection conn = connection.GetConnection())
            {
                Dog dog = null;
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
                        string name = reader.GetString("Name");
                        Species species = (Species)reader.GetInt32("species_id");
                        int shelterid = reader.GetInt32("shelter_id");
                        string shelter = reader.GetString("shelter_name");
                        Gender gender = (Gender)reader.GetInt32("Gender");
                        int age = reader.GetInt32("age");
                        string breed = reader.GetString("breed");
                        bool house = reader.GetBoolean("housetrained");
                        bool sterile = reader.GetBoolean("IsSterile");
                        ActivityLevel active = (ActivityLevel)reader.GetInt32("activitylevel");
                        string images = reader.GetString("Image_link");
                        string? desc; if (!reader.IsDBNull(reader.GetOrdinal("description")))
                        { desc = reader.GetString("Description"); }
                        else { desc = null; }
                        dog = new Dog(Adopter, isAdopted, id, name, shelterid, shelter, species, age, gender, breed, house, sterile, active, desc, images);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return dog;
            }
        }

        public List<Dog> ReadAllDogs()
        {


            string command = "SELECT a.*, s.shelter_name, s.location, s.shelter_address, d.breed, d.housetrained, d.IsSterile, d.activityLevel " +
                "FROM `s2_animals` as a INNER JOIN `s2_dog` as d ON a.Animal_id = d.Animal_id INNER JOIN `s2_shelters` as s ON a.shelter_id = s.shelter_id";
            using (MySqlConnection conn = connection.GetConnection())
            {
                List<Dog> dogs = new List<Dog>();
                MySqlCommand read = new MySqlCommand(command, conn);
                try
                {

                    MySqlDataReader reader = read.ExecuteReader();
                    while (reader.Read())
                    {
                        int? Adopter; if (!reader.IsDBNull(reader.GetOrdinal("Adopter_id")))
                        { Adopter = reader.GetInt32("Adopter_id"); }
                        else { Adopter = null; }
                        bool isAdopted = reader.GetBoolean("adopted_bool");
                        int id = reader.GetInt32("Animal_id");
                        string name = reader.GetString("Name");
                        Species species = (Species)reader.GetInt32("species_id");
                        int shelterid = reader.GetInt32("shelter_id");
                        string shelter = reader.GetString("shelter_name");
                        Gender gender = (Gender)reader.GetInt32("Gender");
                        int age = reader.GetInt32("age");
                        string breed = reader.GetString("breed");
                        bool house = reader.GetBoolean("housetrained");
                        bool sterile = reader.GetBoolean("IsSterile");
                        ActivityLevel active = (ActivityLevel)reader.GetInt32("activitylevel");
                        string images = reader.GetString("Image_link");
                        string? desc; if (!reader.IsDBNull(reader.GetOrdinal("description")))
                        { desc = reader.GetString("Description"); }
                        else { desc = null; }
                        dogs.Add(new Dog(Adopter, isAdopted, id, name, shelterid, shelter, species, age, gender, breed, house, sterile, active, desc, images));
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return dogs;
            }
        }

        public void UpdateDog(Dog d)
        {
            string command = "UPDATE `s2_animals` SET `shelter_id`=@shelter, `Name`=@name, `age`=@age, `Gender`=@gender, `Description`=@description, `Adopter_id`=@adopter, `adopted_bool`=@adoptbool WHERE `Animal_id` = @id";
            string command2 = "UPDATE `s2_dog` SET `breed`=@breed, `housetrained`=@housetrained, `IsSterile`=@sterile, `activitylevel`=@active WHERE `Animal_id` = @id";
            using (MySqlConnection conn = connection.GetConnection())
            {
                MySqlCommand add = new MySqlCommand(command, conn);
                try
                {
                    add.Parameters.AddWithValue("@id", d.id);
                    add.Parameters.AddWithValue("@shelter", d.shelterid);
                    add.Parameters.AddWithValue("@name", d.name);
                    add.Parameters.AddWithValue("@age", d.age);
                    add.Parameters.AddWithValue("@gender", d.gender);
                    add.Parameters.AddWithValue("@description", d.description);
                    add.Parameters.AddWithValue("@adopter", d.adopter_id);
                    add.Parameters.AddWithValue("@adoptbool", d.isAdopted);
                    add.ExecuteNonQuery();
                    MySqlCommand add2 = new MySqlCommand(command2, conn);
                    add2.Parameters.AddWithValue("@id", d.id);
                    add2.Parameters.AddWithValue("@breed", d.breed);
                    add2.Parameters.AddWithValue("@housetrained", d.housetrained);
                    add2.Parameters.AddWithValue("@sterile", d.sterile);
                    add2.Parameters.AddWithValue("@active", d.activityLevel);
                    add2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
