using Domain.Users;
using Domain.CustomException;
using Logic.Hashing;
using Logic.Services.UserService;
using Repository.Database.Users;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Semester_2_Winforms
{
    public partial class Login : Form
    {
        UserManager usermanager;
        User user;

        public Login()
        {
            InitializeComponent();
            usermanager = new UserManager(new UserDB());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = tbx_Username.Text;
            string Password = tbx_Password.Text;
            try
            {
                user = usermanager.GetUserByID(usermanager.GetID(Username));
                if (usermanager.CheckUsername(Username) == true && usermanager.VerifyPassword(Password, Username) == true && user.IsAdmin == true)
                {
                    MainForm mainForm = new MainForm(user);
                    this.Hide(); mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Credentials Invalid");
                }
            }
            catch (NoConnectionException ex) { MessageBox.Show(ex.Message); }
            catch (NotFoundException ex) { MessageBox.Show(ex.Message); }
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                switch (MessageBox.Show(this, "Close Application?", "Closing",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes: Application.Exit(); break;
                    case DialogResult.No: e.Cancel = true; break;
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                user = usermanager.GetUserByID(14);
                MainForm mainForm = new MainForm(user);
                this.Hide(); mainForm.Show();
            }
            catch (NoConnectionException ex) { MessageBox.Show(ex.Message); }
            //catch (Exception ex) { MessageBox.Show("Error\n" + ex.Message); }
        }
    }
}
