using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Users;
using Domain.CustomException;
using Logic.Counter;
using Logic.Hashing;
using Logic.Services.UserService;
using Repository.Database.Users;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Semester_2_Winforms
{
    public partial class RegisterAdmin : Form
    {
        User user;
        UserManager userManager;
        public RegisterAdmin()
        {
            InitializeComponent();
            userManager = new UserManager(new UserDB());
        }

        private bool UserCredentials(string[] strings)
        {
            string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            if (strings.Any(x => string.IsNullOrEmpty(x.ToString())))
            {
                MessageBox.Show("Some fields are empty. Please try again");
                return false;
            }
            if (!Regex.IsMatch(strings[0], pattern))
            {
                MessageBox.Show("Enter a valid email address");
                return false;
            }
            return true;
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string email=tbx_Email.Text;
            string username = tbx_Username.Text;
            string password = tbx_Password.Text;
            var textboxes = new[] { email, username, password };
            try
            {
                if (UserCredentials(textboxes) == true && userManager.CheckUsername(username) != true && password.Length > 7)
                {
                    string hashedpw = Hashing.HashPassword(password);
                    user = new User(email, true, username, hashedpw);

                    userManager.NewUser(user);
                    MessageBox.Show("Admin added");
                    this.Close();
                }
                else if (password.Length < 7)
                {
                    MessageBox.Show("Password Must be at least 8 characters long");
                }
            }
            catch (UserException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegisterAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCounter.Formcounter--;
        }
    }
}
