using Domain.Users;
using Domain.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Counter;

namespace Logic.Services.UserService
{
    public class UserManager
    {
        IUserDB datasource;
        public UserManager(IUserDB datasource)
        {
            this.datasource = datasource;
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            foreach (User u in datasource.ReadAllUsers())
            {
                users.Add(u);
            }
            return users;
        }

        public User GetUserByID(int? id)
        {
            return datasource.GetUserById(id);
        }

        public void NewUser(User user)
        {
            datasource.CreateUser(user);
        }

        public void UpdateUser(User u)
        {
            datasource.UpdateUser(u);
        }

        public void DeleteUser(User u)
        {
            datasource.DeleteUser(u);
        }

        public string HashPassword(string password)
        {
            return Hashing.Hashing.HashPassword(password);
        }

        public bool VerifyPassword(string password, string username)
        {
            return Hashing.Hashing.VerifyPassword(password, GetHashByUsername(username));
        }

        public string GetHashByUsername(string username)
        {
            return datasource.GetPasswordByUsername(username);
        }

        public int? GetID(string Username)
        {
            List<User> users = datasource.ReadAllUsers();
            foreach (User user in users)
            {
                if (Username == user.username)
                {
                    return user.id;
                }
            }
            return null;
        }

        public bool CheckUsername(string Username)
        {
            List<User> users = datasource.ReadAllUsers();
            foreach (User user in users)
            {
                if (Username == user.username)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckEmail(string email)
        {
            List<User> users = datasource.ReadAllUsers();
            foreach (User user in users)
            {
                if (email == user.email)
                {
                    throw new DuplicateInputException("Email is already Taken");
                }
            }
            return false;   
        }

        public bool CheckAgeOver11(DateTime birthdate)
        {
            if(Calculator.ToAge(birthdate) > 11) { return true; }
            throw new AgeException("Age needs to be at least 12");
        }
    }
}
