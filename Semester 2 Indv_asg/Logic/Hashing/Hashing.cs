using System;
using BCrypt.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Hashing
{
    public class Hashing
    {
        public static string HashPassword(string password)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt(12);
            return BCrypt.Net.BCrypt.HashPassword(password, salt);
        }
        public static bool VerifyPassword(string password, string hashedpassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedpassword);
        }
    }
}
