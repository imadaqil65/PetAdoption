using Domain.Animals;
using Domain.enums;
using Domain.Users;
using Domain.CustomException;
using Logic.Services.Animals;
using Logic.Services.UserService;
using Semester_2_Unit_Test.FakeRepo;
using System.Reflection.Metadata;

namespace Semester_2_Unit_Test
{
    [TestClass]
    public class UserManagerTest
    {
        private UserManager userManager;
        private FakeUserDB fakeUserDB;

        public UserManagerTest()
        {
            fakeUserDB = new FakeUserDB();
            userManager = new UserManager(fakeUserDB);
        }

        #region User Manager

        [TestMethod]
        public void CreateUser()
        {
            User u = new User("example@email.com", false, "username", "password");
            userManager.NewUser(u);

            Assert.IsTrue(fakeUserDB.users.Contains(u));
        }

        [TestMethod]
        public void CreateUser_UserNotAddedToRepository()
        {
            User u = new User("example@email.com", false, "username", "password");

            Assert.IsFalse(fakeUserDB.users.Contains(u));
        }

        [TestMethod]
        public void GetHashByUsername()
        {
            string username = "username";
            string password = "password";
            User u = new User(0, "example@email.com", false, username, password);
            userManager.NewUser(u);

            string storedPW = userManager.GetHashByUsername(username);
            Assert.AreEqual(u.password, storedPW);
        }

        [TestMethod]
        public void GetHashByUsername_UsernameNotFound()
        {
            string username = "username";
            string falseUsername = "wrongUsername";
            string password = "password";
            User u = new User(0, "example@email.com", false, username, password);
            userManager.NewUser(u);

            string storedPW = userManager.GetHashByUsername(falseUsername);
            Assert.AreNotEqual(u.password, storedPW);
        }

        [TestMethod]
        public void GetUserByID()
        {
            User u = new User(0, "example@email.com", false, "username", "password");
            userManager.NewUser(u);

            User getuser = userManager.GetUserByID(0);
            Assert.AreEqual(u, getuser);
        }

        [TestMethod]
        
        public void GetUserByID_IDNotFound()
        {
            User u = new User(0, "example@email.com", false, "username", "password");
            userManager.NewUser(u);

            User getuser = userManager.GetUserByID(1);
            Assert.AreNotEqual(u, getuser);
        }

        [TestMethod]
        public void CheckUsername()
        {
            string username = "username";
            string password = "password";
            User u = new User(0, "example@email.com", false, username, password);


            bool UsernameNotTaken = userManager.CheckUsername(username);
            Assert.IsFalse(fakeUserDB.users.Contains(u));
            Assert.IsFalse(UsernameNotTaken);

            userManager.NewUser(u);
            Assert.IsTrue(fakeUserDB.users.Contains(u));
        }

        [TestMethod]
        public void CheckUsername_UsernameTaken()
        {
            string username = "username";
            string password = "password";
            User u = new User(0, "example@email.com", false, username, password);
            userManager.NewUser(u);

            bool UsernameTaken = userManager.CheckUsername(username);
            Assert.IsTrue(UsernameTaken);
        }

        [TestMethod]
        public void GetIDByUsername()
        {
            string username = "username";
            User u = new User(0, "example@email.com", false, username, "password");
            userManager.NewUser(u);

            int? id = userManager.GetID(username);
            Assert.AreEqual(u.id, id);
        }

        [TestMethod]
        //[ExpectedException(typeof(NotFoundException))]
        public void GetIDByUsername_NotFound()
        {
            string username = "username";
            User u = new User(0, "example@email.com", false, "different", "password");
            userManager.NewUser(u);

            int? id = userManager.GetID(username);
            Assert.AreNotEqual(u.id, id);
        }

        [TestMethod]
        public void GetUsers()
        {
            User u1 = new User(0, "example@email.com", false, "different", "password");
            User u2 = new User(1, "example2@email.com", false, "user", "password1");
            User u3 = new User(2, "example3@email.com", false, "username", "password123");
            userManager.NewUser(u1);
            userManager.NewUser(u2);
            userManager.NewUser(u3);

            List<User> Users = userManager.GetUsers();
            CollectionAssert.AreEqual(new List<User> { u1, u2, u3 }, Users);
        }

        [TestMethod]
        public void GetUsers_NotEqual()
        {
            User u1 = new User(0, "example@email.com", false, "different", "password");
            User u2 = new User(1, "example2@email.com", false, "user", "password1");
            User u3 = new User(2, "example3@email.com", false, "username", "password123");
            userManager.NewUser(u1);
            userManager.NewUser(u2);

            List<User> Users = userManager.GetUsers();
            CollectionAssert.AreNotEqual(new List<User> { u1, u2, u3 }, Users);
        }

        [TestMethod]
        public void DeleteUser()
        {
            User u1 = new User(0, "example@email.com", false, "different", "password");
            User u2 = new User(1, "example2@email.com", false, "user", "password1");
            User u3 = new User(2, "example3@email.com", false, "username", "password123");
            userManager.NewUser(u1);
            userManager.NewUser(u2);
            userManager.NewUser(u3);

            userManager.DeleteUser(u1);
            List<User> Users = userManager.GetUsers();
            CollectionAssert.AreEqual(new List<User> { u2, u3 }, Users);
        }

        [TestMethod]
        public void DeleteUser_NotEqual()
        {
            User u1 = new User(0, "example@email.com", false, "different", "password");
            User u2 = new User(1, "example2@email.com", false, "user", "password1");
            User u3 = new User(2, "example3@email.com", false, "username", "password123");
            userManager.NewUser(u1);
            userManager.NewUser(u2);
            userManager.NewUser(u3);

            userManager.DeleteUser(u1);
            userManager.DeleteUser(u2);
            List<User> Users = userManager.GetUsers();
            CollectionAssert.AreNotEqual(new List<User> { u1, u2, u3 }, Users);
        }

        [TestMethod]
        public void UpdateUser()
        {
            User u = new User(0, "example@email.com", false, "username", "password"); 
            userManager.NewUser(u);

            u.id = 1;
            u.email = "example@email.com";
            u.IsAdmin = true;
            u.username = "username";
            u.password = "password";

            userManager.UpdateUser(u);
            User getUser = userManager.GetUserByID(u.id);
            Assert.AreEqual(u, getUser);
        }

        [TestMethod]
        public void UpdateUser_NotEqual()
        {
            User u = new User(0, "example@email.com", false, "username", "password");
            userManager.NewUser(u);

            u.id = 1;
            u.email = "example@email.com";
            u.IsAdmin = true;
            u.username = "username";
            u.password = "password";

            userManager.UpdateUser(u);
            User OldUser = new User(0, "example@email.com", false, "username", "password");
            Assert.AreNotEqual(OldUser, u);
        }

        [TestMethod]
        public void CheckEmail()
        {
            User u = new User(0, "example@email.com", false, "username", "password");
            User u2 = new User(1, "example2@email.com", false, "user", "password1");
            userManager.NewUser(u2);

            bool email = userManager.CheckEmail(u.email);
            Assert.IsFalse(email);
        }

        [TestMethod]
        [ExpectedException(typeof(DuplicateInputException))]
        public void CheckEmail_EmailTaken()
        {
            User u = new User(0, "example@email.com", false, "username", "password");
            userManager.NewUser(u);

            bool email = userManager.CheckEmail(u.email);
            Assert.IsTrue(email);
        }

        [TestMethod]
        public void CheckAgeOver11()
        {
            DateTime date = new DateTime(2004,06,21);
            bool checkage = userManager.CheckAgeOver11(date);

            Assert.IsTrue(checkage);
        }

        [TestMethod]
        [ExpectedException(typeof(AgeException))]
        public void CheckAgeOver11_Exceptionthrown()
        {
            DateTime date = new DateTime(2023, 06, 06);
            bool checkage = userManager.CheckAgeOver11(date);
        }

        [TestMethod]
        public void VerifyPassword()
        {
            string username = "kamehameha";
            string password = "humuhumunukunukuupua";
            string hashedpassword = userManager.HashPassword(password);
            User u = new User(0, "email@email.com", false, username, hashedpassword);
            userManager.NewUser(u);

            bool verified = userManager.VerifyPassword(password, username);
            Assert.IsTrue(verified);
        }

        [TestMethod]
        //[ExpectedException(typeof(NotFoundException))]
        public void VerifyPassword_WrongPassword()
        {
            string username = "kamehameha";
            string password = "humuhumunukunukuupua";
            string hashedpassword = userManager.HashPassword(password);
            User u = new User(0, "email@email.com", false, username, hashedpassword);
            userManager.NewUser(u);

            bool verified = userManager.VerifyPassword(username, username);
            Assert.IsFalse(verified);
        }
        #endregion

    }
}
