using Domain.CustomException;
using Domain.Users;
using Logic.Services.UserService;
using MySql.Data.MySqlClient;

namespace Repository.Database.Users
{
    public class UserDB : IUserDB
    {
        Connection connection = new Connection();

        public Connection Connection
        {
            get => default;
            set
            {
            }
        }

        public void CreateUser(User u)
        {
            string command = "INSERT INTO `s2_user` (`EMAIL`, `USERNAME`, `ISADMIN`, `PASSWORD`, `ADDRESS`, `FIRSTNAME`, `LASTNAME`, `BIRTHDATE`) VALUES (@EMAIL, @USERNAME, @ISADMIN, @PASSWORD, @ADDRESS, @FIRSTNAME, @LASTNAME, @BIRTHDATE);";
            MySqlConnection conn = connection.GetConnection();
            MySqlCommand add = new MySqlCommand(command, conn);
            try
            {
 
                add.Parameters.AddWithValue("@EMAIL", u.email);
                add.Parameters.AddWithValue("@ISADMIN", u.IsAdmin);
                add.Parameters.AddWithValue("@USERNAME", u.username);
                add.Parameters.AddWithValue("@PASSWORD", u.password);
                add.Parameters.AddWithValue("@ADDRESS", u.address);
                add.Parameters.AddWithValue("@FIRSTNAME", u.firstname);
                add.Parameters.AddWithValue("@LASTNAME", u.lastname);
                add.Parameters.AddWithValue("@BIRTHDATE", u.birthdate);

                MySqlDataReader reader = add.ExecuteReader();
            }
            catch (Exception ex) /*Exception not implemented*/
            {
                throw new UserException("An error has occured during adding");
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteUser(User u)
        {
            string command = "DELETE FROM `s2_user` WHERE `USER_ID` = @ID";
            MySqlConnection conn = connection.GetConnection();
            MySqlCommand add = new MySqlCommand(command, conn);
            try
            {

                add.Parameters.AddWithValue("@ID", u.id);
                MySqlDataReader reader = add.ExecuteReader();
            }
            catch
            {
                throw new UserException($"An error has occured during deleting");
            }
            finally
            {
                conn.Close();
            };
        }

        public string GetPasswordByUsername(string name)
        {
            string hash = null;
            string command = "SELECT `PASSWORD` FROM `s2_user` WHERE `USERNAME` = @name";
            using (MySqlConnection conn = connection.GetConnection())
            {
                MySqlCommand add = new MySqlCommand(command, conn);
                try
                {
           
                    add.Parameters.AddWithValue("@name", name);
                    MySqlDataReader reader = add.ExecuteReader();
                    while (reader.Read())
                    {
                        hash = reader.GetString("PASSWORD");
                    }
                }
                catch { throw new NotFoundException("User Not Found"); }
                return hash;
            }
            return null;
        }

        public User GetUserById(int? id)
        {
            User user = null;
            string command = "SELECT * FROM `s2_user` WHERE `USER_ID` = @id";
            MySqlConnection conn = connection.GetConnection();
            MySqlCommand add = new MySqlCommand(command, conn);
            try
            {
                add.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = add.ExecuteReader();
                while (reader.Read())
                {
                    int userid = reader.GetInt32("USER_ID");
                    string email = reader.GetString("EMAIL");
                    string username = reader.GetString("USERNAME");
                    string password = reader.GetString("PASSWORD");
                    bool admin = reader.GetBoolean("ISADMIN");
                    if (!reader.IsDBNull(reader.GetOrdinal("FIRSTNAME")) && !reader.IsDBNull(reader.GetOrdinal("LASTNAME")) && !reader.IsDBNull(reader.GetOrdinal("ADDRESS")) && !reader.IsDBNull(reader.GetOrdinal("BIRTHDATE")))
                    {
                        string? firstname = reader.GetString("FIRSTNAME");
                        string? lastname = reader.GetString("LASTNAME");
                        string? address = reader.GetString("ADDRESS");
                        DateTime? birthdate = reader.GetDateTime("BIRTHDATE");
                        user = new User(userid, email, admin, username, password, firstname, lastname, address, birthdate);
                    }
                    else
                    {
                        string? firstname = null;
                        string? lastname = null;
                        string? address = null;
                        DateTime? birthdate = null;
                        user = new User(userid, email, admin, username, password, firstname, lastname, address, birthdate);
                    }
                }
            }
            catch { throw new NotFoundException("User Not Found"); }
            finally
            {
                conn.Close();
            };
            return user;
        }

        public List<User> ReadAllUsers()
        {
            List<User> customers = new List<User>();

            string command = "SELECT * FROM `s2_user`";
            MySqlConnection conn = connection.GetConnection();
            MySqlCommand read = new MySqlCommand(command, conn);
            try
            {
            

                MySqlDataReader reader = read.ExecuteReader();
                while (reader.Read())
                {
                    int userid = reader.GetInt32("USER_ID");
                    string email = reader.GetString("EMAIL");
                    string username = reader.GetString("USERNAME");
                    string password = reader.GetString("PASSWORD");
                    bool admin = reader.GetBoolean("ISADMIN");
                    if (!reader.IsDBNull(reader.GetOrdinal("FIRSTNAME")) && !reader.IsDBNull(reader.GetOrdinal("LASTNAME")) && !reader.IsDBNull(reader.GetOrdinal("ADDRESS")) && !reader.IsDBNull(reader.GetOrdinal("BIRTHDATE")))
                    {
                        string? firstname = reader.GetString("FIRSTNAME");
                        string? lastname = reader.GetString("LASTNAME");
                        string? address = reader.GetString("ADDRESS");
                        DateTime? birthdate = reader.GetDateTime("BIRTHDATE");
                        customers.Add(new User(userid, email, admin, username, password, firstname, lastname, address, birthdate));
                    }
                    else
                    {
                        string? firstname = null;
                        string? lastname = null;
                        string? address = null;
                        DateTime? birthdate = null;
                        customers.Add(new User(userid, email, admin, username, password, firstname, lastname, address, birthdate));
                    }
                }
            }
            //catch (NoConnectionException ex) { throw new NoConnectionException(ex.Message); }
            //TODO: work on proper exhceptions
            catch
            {
                throw new UserException("An error has occured while reading users");
            }
            finally
            {
                conn.Close();
            }

            return customers;
        }

        public void UpdateUser(User u)
        {
            string command = "UPDATE `s2_user` SET `EMAIL`=@EMAIL, `USERNAME`=@USERNAME, `PASSWORD`=@PASSWORD, `ISADMIN`=@ISADMIN, `FIRSTNAME`=@FIRSTNAME, `LASTNAME`=@LASTNAME, `ADDRESS`=@ADDRESS, `BIRTHDATE`=@BIRTHDATE  WHERE USER_ID = @ID";
            MySqlConnection conn = connection.GetConnection();
            MySqlCommand add = new MySqlCommand(command, conn);
            try
            {
      
                add.Parameters.AddWithValue("@ID", u.id);
                add.Parameters.AddWithValue("@EMAIL", u.email);
                add.Parameters.AddWithValue("@ISADMIN", u.IsAdmin);
                add.Parameters.AddWithValue("@USERNAME", u.username);
                add.Parameters.AddWithValue("@PASSWORD", u.password);
                add.Parameters.AddWithValue("@FIRSTNAME", u.firstname);
                add.Parameters.AddWithValue("@LASTNAME", u.lastname);
                add.Parameters.AddWithValue("@ADDRESS", u.address);
                add.Parameters.AddWithValue("@BIRTHDATE", u.birthdate);
                MySqlDataReader reader = add.ExecuteReader();
            }
            //catch (NoConnectionException ex) { throw new NoConnectionException(ex.Message); }
            catch
            {
                throw new UserException("An error has occured while updating users");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
