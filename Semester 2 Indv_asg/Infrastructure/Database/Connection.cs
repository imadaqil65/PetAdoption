using MySql.Data.MySqlClient;
using Domain.CustomException;

namespace Repository.Database
{
    public class Connection
    {
        public MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi499768;Database=dbi499768;Pwd=Kudripseugo6;SslMode=none;");
                conn.Open();
                return conn;
            }
            catch
            {
                throw new NoConnectionException("No Connection could be made");
            }
        }
    }
}
