using MySql.Data.MySqlClient;
using Logic.Services.Animals;
using Domain.Animals;
using Domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Database.Animals
{
    public class AnimalDB : IAnimalDB
    {
        Connection connection = new Connection();

        public Connection Connection
        {
            get => default;
            set
            {
            }
        }

        public void CreateAnimal(Animal a)
        {
            string command = "INSERT INTO `s2_animals` (`Name`, `species_id`, `shelter_id`, `age`, `Gender`, `Description`, `Image_link`) VALUES (@Name, @Species, @Shelter, @age, @Gender, @Desc, 'img/Animals/placeholder.jpg');";
            MySqlConnection conn = connection.GetConnection();
            MySqlCommand add = new MySqlCommand(command, conn);
            try
            {
                add.Parameters.AddWithValue("@Name", a.name);
                add.Parameters.AddWithValue("@Species", a.species);
                add.Parameters.AddWithValue("@Shelter", a.shelterid);
                add.Parameters.AddWithValue("@Gender", a.gender);
                add.Parameters.AddWithValue("@age", a.age);
                add.Parameters.AddWithValue("@Desc", a.description);
                MySqlDataReader reader = add.ExecuteReader();
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

        public void DeleteAnimal(Animal a)
        {
            string command = "DELETE FROM `s2_animals` WHERE `Animal_id` = @id";
            MySqlConnection conn = connection.GetConnection();
            MySqlCommand add = new MySqlCommand(command, conn);
            try
            {
                add.Parameters.AddWithValue("@id", a.id);
                MySqlDataReader reader = add.ExecuteReader();
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
        }

        public Animal GetAnimalByID(int id)
        {
            string command = "SELECT a.*, s.shelter_name, s.location, s.shelter_address FROM `s2_animals` as a INNER JOIN `s2_shelters` as s ON " +
                "a.shelter_id = s.shelter_id WHERE `Animal_id` = @id";
            Animal animal = null;
            MySqlConnection conn = connection.GetConnection();
            MySqlCommand add = new MySqlCommand(command, conn);
            try
            {
                add.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = add.ExecuteReader();
                while (reader.Read())
                {
                    int? Adopter; if (!reader.IsDBNull(reader.GetOrdinal("Adopter_id")))
                    { Adopter  = reader.GetInt32("Adopter_id"); }
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
                    string? desc; if(!reader.IsDBNull(reader.GetOrdinal("description")))
                    { desc = reader.GetString("Description"); } else { desc = null; }
                    animal = new Animal(Adopter, isAdopted, Animal_id, name, shelterid, shelter, species, age, gender, desc, images);
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
            return animal;
        }

        public List<Animal> GetAnimalBySpecies(Species species)
        {
            //throw new NotImplementedException();
            string command = "SELECT a.*, s.shelter_name, s.location, s.shelter_address FROM `s2_animals` as a INNER JOIN `s2_shelters` as s ON " +
                "a.shelter_id = s.shelter_id WHERE `species_id` = @species";
            List<Animal> animals = new List<Animal>();
            MySqlConnection conn = connection.GetConnection();
            MySqlCommand add = new MySqlCommand(command, conn);
            try
            {
                add.Parameters.AddWithValue("@species", species);
                MySqlDataReader reader = add.ExecuteReader();
                while (reader.Read())
                {
                    int? Adopter; if (!reader.IsDBNull(reader.GetOrdinal("Adopter_id")))
                    { Adopter = reader.GetInt32("Adopter_id"); }
                    else { Adopter = null; }
                    bool isAdopted = reader.GetBoolean("adopted_bool");
                    int Animal_id = reader.GetInt32("Animal_id");
                    string name = reader.GetString("Name");
                    int shelterid = reader.GetInt32("shelter_id");
                    string shelter = reader.GetString("shelter_name");
                    Gender gender = (Gender)reader.GetInt32("Gender");
                    int age = reader.GetInt32("age");
                    string images = reader.GetString("Image_link");
                    string? desc; if (!reader.IsDBNull(reader.GetOrdinal("description")))
                    { desc = reader.GetString("Description"); } else { desc = null; }
                    animals.Add(new Animal(Adopter, isAdopted, Animal_id, name, shelterid, shelter, species, age, gender, desc, images));
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
            return animals;
        }

        public List<Animal> ReadAllAnimals()
        {
            List<Animal> animalslist = new List<Animal>();

            string command = "SELECT a.*, s.shelter_name, s.location, s.shelter_address FROM `s2_animals` a INNER JOIN `s2_shelters` s ON " +
                "a.shelter_id = s.shelter_id";
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
                    string shelter = reader.GetString("shelter_name");
                    int shelterid = reader.GetInt32("shelter_id");
                    Species species = (Species)reader.GetInt32("species_id");
                    int age = reader.GetInt32("age");
                    Gender gender = (Gender)reader.GetInt32("Gender");
                    string? desc = reader.GetString("Description");
                    string images = reader.GetString("Image_link");
                    animalslist.Add(new Animal(Adopter, isAdopted, id, name, shelterid, shelter, species, age, gender, desc, images));
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
            return animalslist;
        }

        public void UpdateAnimal(Animal a)
        {
            string command = "UPDATE `s2_animals` SET /*`species_id`=@species,*/ `shelter_id`=@shelter, `Name`=@name, `age`=@age, `Gender`=@gender, `Description`=@description, `Adopter_id`=@adopter, `adopted_bool`=@adoptbool WHERE `Animal_id` = @id";
            MySqlConnection conn = connection.GetConnection();
            MySqlCommand add = new MySqlCommand(command, conn);
            try
            {
                add.Parameters.AddWithValue("@id", a.id);
                //add.Parameters.AddWithValue("@species", a.species);
                add.Parameters.AddWithValue("@shelter", a.shelterid);
                add.Parameters.AddWithValue("@name", a.name);
                add.Parameters.AddWithValue("@age", a.age);
                add.Parameters.AddWithValue("@gender", a.gender);
                add.Parameters.AddWithValue("@description", a.description);
                add.Parameters.AddWithValue("@adopter", a.adopter_id);
                add.Parameters.AddWithValue("@adoptbool", a.isAdopted);
                add.ExecuteNonQuery();
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
