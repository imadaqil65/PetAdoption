using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals.CatService;
using MySql.Data.MySqlClient;
namespace Repository.Database.Animals
{
    public class CatDB : ICatDB
    {
        Connection connection = new Connection();

        public Connection Connection
        {
            get => default;
            set
            {
            }
        }

        public void CreateCat(Cat c)
        {
            string command = "INSERT INTO `s2_animals` (`Name`, `species_id`, `shelter_id`, `age`, `Gender`, `Description`, `Image_link`) VALUES" +
                " (@Name, @Species, @Shelter, @age, @Gender, @Desc, 'img/Animals/AICat.jpg'); SELECT LAST_INSERT_ID()";
            string command2 = "INSERT INTO `s2_cat` (`Animal_id`, `breed`, `furcolor`, `allergies`, `sterile`) VALUES" +
                " (@id, @breed, @furcolor, @allergies, @sterile)";
            using (MySqlConnection conn = connection.GetConnection())
            {
                MySqlCommand add = new MySqlCommand(command, conn);
                try
                {

                    add.Parameters.AddWithValue("@Name", c.name);
                    add.Parameters.AddWithValue("@Species", c.species);
                    add.Parameters.AddWithValue("@Shelter", c.shelterid);
                    add.Parameters.AddWithValue("@Gender", c.gender);
                    add.Parameters.AddWithValue("@age", c.age);
                    add.Parameters.AddWithValue("@Desc", c.description);

                    int animalID = int.Parse(add.ExecuteScalar().ToString());

                    MySqlCommand addToTable = new MySqlCommand(command2, conn);
                    addToTable.Parameters.AddWithValue("@id", animalID);
                    addToTable.Parameters.AddWithValue("@breed", c.breed);
                    addToTable.Parameters.AddWithValue("@furcolor", c.furcolor);
                    addToTable.Parameters.AddWithValue("@allergies", c.allergies);
                    addToTable.Parameters.AddWithValue("@sterile", c.IsSterile);
                    addToTable.ExecuteNonQuery();
                }
                catch (Exception ex) /*Exception not implemented*/
                {
                    throw new Exception($"Cannot create entity\n{ex.Message}");
                }
            }
        }

        public void DeleteCat(Cat c)
        {
            string command = "DELETE FROM `s2_animals` WHERE `Animal_id` = @id";
            using (MySqlConnection conn = connection.GetConnection())
            {
                MySqlCommand add = new MySqlCommand(command, conn);
                try
                {
                    add.Parameters.AddWithValue("@id", c.id);
                    MySqlDataReader reader = add.ExecuteReader();
                }
                //TODO: work on proper exhceptions
                catch (Exception ex)
                {
                    throw new Exception($"Cannot delete entity\n{ex.Message}");
                }
            }
        }

        public Cat GetCatByID(int id)
        {
            string command = "SELECT a.*, s.shelter_name, s.location, s.shelter_address, c.breed, c.furcolor, c.allergies, c.sterile" +
                " FROM `s2_animals` as a INNER JOIN `s2_cat` as c ON a.Animal_id = c.Animal_id INNER JOIN `s2_shelters` as s ON a.shelter_id = s.shelter_id WHERE a.Animal_id = @id";
            Cat cat = null;
            MySqlConnection conn = connection.GetConnection();
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
                    string shelter = reader.GetString("shelter_name");
                    int shelterid = reader.GetInt32("shelter_id");
                    Gender gender = (Gender)reader.GetInt32("Gender");
                    int age = reader.GetInt32("age");
                    string breed = reader.GetString("breed");
                    string furcolor = reader.GetString("furcolor");
                    string allergies = reader.GetString("allergies");
                    bool sterile = reader.GetBoolean("sterile");
                    string images = reader.GetString("Image_link");
                    string? desc; if (!reader.IsDBNull(reader.GetOrdinal("description")))
                    { desc = reader.GetString("Description"); }
                    else { desc = null; }
                    cat = new Cat(Adopter, isAdopted, id, name, shelterid, shelter, species, age, gender, breed, furcolor, allergies, sterile, desc, images);
                }
            }
            //TODO: work on proper exhceptions
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            };
            return cat;
        }

        public List<Cat> ReadAllCats()
        {
            List<Cat> cats = new List<Cat>();

            string command = "SELECT a.*, s.shelter_name, s.location, s.shelter_address, c.breed, c.furcolor, c.allergies, c.sterile" +
                " FROM `s2_animals` as a INNER JOIN `s2_cat` as c ON a.Animal_id = c.Animal_id INNER JOIN `s2_shelters` as s ON a.shelter_id = s.shelter_id";
            MySqlConnection conn = connection.GetConnection();
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
                    int shelterid = reader.GetInt32("shelter_id");
                    string shelter = reader.GetString("shelter_name");
                    Species species = (Species)reader.GetInt32("species_id");
                    int age = reader.GetInt32("age");
                    Gender gender = (Gender)reader.GetInt32("Gender");
                    string breed = reader.GetString("breed");
                    string furcolor = reader.GetString("furcolor");
                    string allergies = reader.GetString("allergies");
                    bool sterile = reader.GetBoolean("sterile");
                    string images = reader.GetString("Image_link");
                    string? desc; if (!reader.IsDBNull(reader.GetOrdinal("description")))
                    { desc = reader.GetString("Description"); }
                    else { desc = null; }
                    cats.Add(new Cat(Adopter, isAdopted, id, name, shelterid, shelter, species, age, gender, breed, furcolor, allergies, sterile, desc, images));

                }

            }
            //TODO: work on proper exhceptions
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return cats;
        }

        public void UpdateCat(Cat c)
        {
            string command = "UPDATE `s2_animals` SET `shelter_id`=@shelter, `Name`=@name, `age`=@age, `Gender`=@gender, `Description`=@description, `Adopter_id`=@adopter, `adopted_bool`=@adoptbool WHERE `Animal_id` = @id";
            string command2 = "UPDATE `s2_cat` SET `breed`=@breed, `furcolor`=@furcolor, `allergies`=@allergies, `sterile`=@sterile WHERE `Animal_id` = @id";
            MySqlConnection conn = connection.GetConnection();
            MySqlCommand add = new MySqlCommand(command, conn);
            try
            {
                add.Parameters.AddWithValue("@id", c.id);
                add.Parameters.AddWithValue("@shelter", c.shelterid);
                add.Parameters.AddWithValue("@name", c.name);
                add.Parameters.AddWithValue("@age", c.age);
                add.Parameters.AddWithValue("@gender", c.gender);
                add.Parameters.AddWithValue("@description", c.description);
                add.Parameters.AddWithValue("@adopter", c.adopter_id);
                add.Parameters.AddWithValue("@adoptbool", c.isAdopted);
                add.ExecuteNonQuery();
                MySqlCommand add2 = new MySqlCommand(command2, conn);
                add2.Parameters.AddWithValue("@id", c.id);
                add2.Parameters.AddWithValue("@breed", c.breed);
                add2.Parameters.AddWithValue("@furcolor", c.furcolor);
                add2.Parameters.AddWithValue("@allergies", c.allergies);
                add2.Parameters.AddWithValue("@sterile", c.IsSterile);
                add2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
