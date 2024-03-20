using Domain.Shelters;
using Logic.Services.ShelterService;
using MySql.Data.MySqlClient;

namespace Repository.Database.Shelters
{
    public class ShelterDB : IShelterDB
    {
        Connection connection = new Connection();

        public Connection Connection
        {
            get => default;
            set
            {
            }
        }

        public void CreateShelter(Shelter s)
        {
            string command = "INSERT INTO `s2_shelters` (`shelter_id`, `shelter_name`, `location`, `shelter_address`) VALUES (@id, @name, @location, @address);";
            MySqlConnection conn = connection.GetConnection();
            MySqlCommand add = new MySqlCommand(command, conn);
            try
            {

                add.Parameters.AddWithValue("@id", s.id);
                add.Parameters.AddWithValue("@name", s.name);
                add.Parameters.AddWithValue("@location", s.location);
                add.Parameters.AddWithValue("@address", s.address);

                MySqlDataReader reader = add.ExecuteReader();
            }
            catch (Exception ex) /*Exception not implemented*/
            {
                return;
            }
            finally
            {
                conn.Close();
            };
        }

        // Delete Not Implemented
        public void DeleteShelter(Shelter s)
        {
            using (MySqlConnection conn = connection.GetConnection())
            {
                string command = "DELETE FROM `s2_shelters` WHERE `shelter_id` = @id";
                MySqlCommand delete = new MySqlCommand(command, conn);
                try
                {
                    delete.Parameters.AddWithValue("@id", s.id);
                    delete.ExecuteNonQuery();
                }
                catch
                {

                }
            }
        }

        public Shelter GetShelterById(int id)
        {
            Shelter shelter = null;
            using (MySqlConnection conn = connection.GetConnection())
            {
                string command = "SELECT * FROM `s2_shelters` WHERE `shelter_id` = @id";

                MySqlCommand add = new MySqlCommand(command, conn);
                try
                {
    
                    add.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = add.ExecuteReader();
                    while (reader.Read())
                    {
                        int shelter_id = reader.GetInt32("shelter_id");
                        string name = reader.GetString("shelter_name");
                        string location = reader.GetString("location");
                        string address = reader.GetString("shelter_address");
                        shelter = new Shelter(shelter_id, name, location, address);
                    }
                }
                catch { }
            }
            return shelter;
        }

        public List<Shelter> ReadAllShelters()
        {
            List<Shelter> shelters = new List<Shelter>();

            string command = "SELECT * FROM `s2_shelters`";
            MySqlConnection conn = connection.GetConnection();
            MySqlCommand read = new MySqlCommand(command, conn);
            try
            {


                MySqlDataReader reader = read.ExecuteReader();
                while (reader.Read())
                {
                    int shelter_id = reader.GetInt32("shelter_id");
                    string name = reader.GetString("shelter_name");
                    string location = reader.GetString("location");
                    string address = reader.GetString("shelter_address");
                    shelters.Add(new Shelter(shelter_id, name, location, address));
                }
            }
            catch { }
            finally { conn.Close(); };
            return shelters;
        }


        public void UpdateShelter(Shelter s)
        {
            using (MySqlConnection conn = connection.GetConnection())
            {
                string command = "UPDATE `s2_shelters` SET `shelter_name`=@name, `location`=@location, `shelter_address`=@address WHERE `shelter_id`=@id";
                MySqlCommand update = new MySqlCommand(command, conn);
                try
                {
                    update.Parameters.AddWithValue("@id", s.id);
                    update.Parameters.AddWithValue("@name", s.name);
                    update.Parameters.AddWithValue("@location", s.location);
                    update.Parameters.AddWithValue("@address", s.address);

                    MySqlDataReader reader = update.ExecuteReader();
                }
                catch (Exception ex) { throw new Exception("Update cannot be executed", ex); }
            }
        }
    }
}
