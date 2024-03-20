using Domain.Users;
using Logic.Counter;
using Semester_2_Winforms.UserControls;
using Semester_2_Winforms.UserControls.Store_Management;

namespace Semester_2_Winforms
{
    public partial class MainForm : Form
    {
        User user;
        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
            lbl_User.Text = $"Welcome {user.username}!";
        }

        private void btn_Cats_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new CatsControl());
        }

        private void btn_Dogs_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new DogsControl());
        }

        private void btn_Birds_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new BirdsControl());
        }

        private void btn_Hamsters_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new HamstersControl());
        }
        private void btn_PendingAdoption_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new AdoptionControl());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "Want To Logout?", "Logging Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Login LoginForm = new Login();
                    LoginForm.Show(); this.Hide(); ; break;
                case DialogResult.No: break;
            }
        }

        private void btn_RegisterAdmin_Click(object sender, EventArgs e)
        {
            if (FormCounter.Formcounter == 0)
            {
                FormCounter.Formcounter++;
                {
                    RegisterAdmin regAdmin = new RegisterAdmin();
                    regAdmin.Show();
                }
            }
        }

        private void btn_Shelters_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new ShelterControl());
        }

        private void btn_AdoptedAnimals_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new AdoptedAnimalsControl());
        }
    }
}
