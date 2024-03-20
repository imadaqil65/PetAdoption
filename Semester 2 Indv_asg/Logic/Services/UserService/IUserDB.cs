using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Users;

namespace Logic.Services.UserService
{
    public interface IUserDB
    {
        public void CreateUser(User u);
        public void UpdateUser(User u);
        public void DeleteUser(User u);
        public List<User> ReadAllUsers();
        public User GetUserById(int? id);
        public string GetPasswordByUsername(string name);
    }
}
