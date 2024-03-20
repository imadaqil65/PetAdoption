using Domain.Adoption;
using Domain.enums;
using Logic.Services.Adoption;
using MySql.Data.MySqlClient;

namespace Repository.Database.Adoption
{
    public class PendingAdoptionDB : IPendingAdoptionDB
    {
        Connection connection = new Connection();

        public Connection Connection
        {
            get => default;
            set
            {
            }
        }

        public void CreateAdoptionRequest(PendingAdoption pa)
        {
            using (MySqlConnection conn = connection.GetConnection())
            {
                string command = "INSERT INTO `s2_pending_adoption` (`user_id`, `animal_id`) VALUES (@user,@animal)";
                MySqlCommand add = new MySqlCommand(command, conn);
                try
                {
                    add.Parameters.AddWithValue("@user", pa.User_id);
                    add.Parameters.AddWithValue("@animal", pa.Animal_id);
                    MySqlDataReader reader = add.ExecuteReader();
                }
                catch { }
            }
        }

        public void DeleteAdoptionRequest(PendingAdoption pa)
        {
            using (MySqlConnection conn = connection.GetConnection())
            {
                string command = "DELETE FROM `s2_pending_adoption` WHERE `adoption_id` = @adoptionid";
                MySqlCommand delete = new MySqlCommand(command, conn);
                try
                {
                    delete.Parameters.AddWithValue("@adoptionid", pa.Adoption_id);
                    MySqlDataReader reader = delete.ExecuteReader();
                }
                catch { }
            }
        }

        public void ApproveAdoptionRequest(PendingAdoption pa)
        {
            using (MySqlConnection conn = connection.GetConnection())
            {
                string command = "DELETE FROM `s2_pending_adoption` WHERE `animal_id` = @animalid";
                MySqlCommand delete = new MySqlCommand(command, conn);
                try
                {
                    delete.Parameters.AddWithValue("@animalid", pa.Animal_id);
                    MySqlDataReader reader = delete.ExecuteReader();
                }
                catch { }
            }
        }

        public PendingAdoption GetAdoptionRequestByID(int id)
        {
            using (MySqlConnection conn = connection.GetConnection())
            {
                PendingAdoption pendingAdoption = null;
                string command = "SELECT pa.*, a.*, u.FIRSTNAME, u.LASTNAME, u.ADDRESS, sh.* FROM `s2_pending_adoption` as pa INNER JOIN `s2_animals` as a ON pa.animal_id = a.Animal_id " +
                    "INNER JOIN `s2_user` as u ON pa.user_id = u.USER_ID INNER JOIN `s2_shelters` as sh ON a.shelter_id = sh.shelter_id WHERE `adoption_id` = @adoptionid";
                MySqlCommand add = new MySqlCommand(command, conn);
                try
                {
                    add.Parameters.AddWithValue("@adoptionid", id);

                    MySqlDataReader reader = add.ExecuteReader();
                    while (reader.Read())
                    {
                        int adoptionid = reader.GetInt32("adoption_id");
                        int userid = reader.GetInt32("user_id");
                        int animalid = reader.GetInt32("animal_id");
                        string animalname = reader.GetString("Name");
                        Species species = (Species)reader.GetInt32("species_id");
                        string firstname = reader.GetString("FIRSTNAME");
                        string lastname = reader.GetString("LASTNAME");
                        string customerAddress = reader.GetString("ADDRESS");
                        string sheltername = reader.GetString("shelter_name");
                        string shelteraddress = $"{reader.GetString("shelter_address")}, {reader.GetString("location")}";
                        pendingAdoption = new PendingAdoption(adoptionid, userid, animalid, animalname, species, firstname, lastname, customerAddress, sheltername, shelteraddress);
                    }
                }
                catch { }
                return pendingAdoption;
            }
        }

        public List<PendingAdoption> ReadAllAdoptionRequest()
        {
            using (MySqlConnection conn = connection.GetConnection())
            {
                List<PendingAdoption> pendingAdoptions = new List<PendingAdoption>();
                string command = "SELECT pa.*, a.*, u.FIRSTNAME, u.LASTNAME, u.ADDRESS, sh.* FROM `s2_pending_adoption` as pa INNER JOIN `s2_animals` as a ON pa.animal_id = a.Animal_id " +
                    "INNER JOIN `s2_user` as u ON pa.user_id = u.USER_ID INNER JOIN `s2_shelters` as sh ON a.shelter_id = sh.shelter_id";
                MySqlCommand read = new MySqlCommand(command, conn);
                try
                {
                    MySqlDataReader reader = read.ExecuteReader();
                    while (reader.Read())
                    {
                        int adoptionid = reader.GetInt32("adoption_id");
                        int userid = reader.GetInt32("user_id");
                        int animalid = reader.GetInt32("animal_id");
                        string animalname = reader.GetString("Name");
                        Species species = (Species)reader.GetInt32("species_id");
                        string firstname = reader.GetString("FIRSTNAME");
                        string lastname = reader.GetString("LASTNAME");
                        string customerAddress = reader.GetString("ADDRESS");
                        string sheltername = reader.GetString("shelter_name");
                        string shelteraddress = $"{reader.GetString("shelter_address")}, {reader.GetString("location")}";
                        pendingAdoptions.Add(new PendingAdoption(adoptionid, userid, animalid, animalname, species, firstname, lastname, customerAddress, sheltername, shelteraddress));
                    }
                }
                catch { }
                return pendingAdoptions;
            }
        }

        public void UpdateAdoptionRequest(PendingAdoption pa)
        {
            using (MySqlConnection conn = connection.GetConnection())
            {
                string command = "UPDATE `s2_pending_adoption` SET `user_id`=@user, `animal_id`=@animal";
                MySqlCommand add = new MySqlCommand(command, conn);
                try
                {
    
                    add.Parameters.AddWithValue("@user", pa.User_id);
                    add.Parameters.AddWithValue("@animal", pa.Animal_id);
                    MySqlDataReader reader = add.ExecuteReader();
                }
                catch { }
            }
        }
    }
}
