using Domain.Users;
using Logic.Services.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Semester_2_Unit_Test.FakeRepo
{
    public class FakeUserDB : IUserDB
    {
        public List<User> users { get; }

        public FakeUserDB()
        {
            users = new List<User>();
        }

        public void CreateUser(User u)
        {
            users.Add(u);
        }

        public void DeleteUser(User u)
        {
            users.Remove(u);
        }

        public string GetPasswordByUsername(string name)
        {
            foreach (User user in users) 
            {
                if (name == user.username)
                {
                    return user.password;
                }
            }
            return string.Empty; 
        }

        public User GetUserById(int? id)
        {
            foreach (User user in users)
            {
                if (id == user.id)
                {
                    return user;
                }
            }
            return null;
        }

        public List<User> ReadAllUsers()
        {
            return users;
        }

        public void UpdateUser(User u)
        {
            users[u.id -1] = u;
        }
    }
}
