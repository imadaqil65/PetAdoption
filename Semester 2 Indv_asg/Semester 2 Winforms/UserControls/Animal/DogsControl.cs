using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals.DogService;
using Logic.Services.ShelterService;
using Repository.Database.Animals;
using Repository.Database.Shelters;
using Semester_2_Winforms.UserControls.Animal;

namespace Semester_2_Winforms.UserControls
{
    public partial class DogsControl : UserControl
    {
        ShelterManager shelterManager;
        DogManager dogmanager;
        Dog dog;
        public DogsControl()
        {
            InitializeComponent();
            dogmanager = new DogManager(new DogDB());
            FillComboBoxes();
            FillDogsFlowLayoutPanel();
        }
        public void FillComboBoxes()
        {
            cbx_DogGender.DataSource = Enum.GetValues(typeof(Gender));
            Cbx_ActivityLevel.DataSource = Enum.GetValues(typeof(ActivityLevel));
            shelterManager = new ShelterManager(new ShelterDB());
            cbx_DogShelter.DataSource = shelterManager.GetShelters();
            cbx_DogShelter.DisplayMember = "name";
            cbx_DogShelter.ValueMember = "id";
        }

        public void FillDogsFlowLayoutPanel()
        {
            try
            {
                flp_AvailableDogs.Controls.Clear();
                foreach (var v in dogmanager.GetDogs())
                {
                    DogsIndividual I = new DogsIndividual(v, this);
                    flp_AvailableDogs.Controls.Add(I);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_AddDog_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbx_DogName.Text;
                int shelter = Convert.ToInt32(cbx_DogShelter.SelectedValue);
                int age = Convert.ToInt32(nud_DogAge.Value);
                string desc = richtbx_DogDesc.Text;
                string breed = tbx_DogBreed.Text;
                Gender gender;
                Enum.TryParse<Gender>(cbx_DogGender.SelectedValue.ToString(), out gender);
                ActivityLevel activityLevel;
                Enum.TryParse<ActivityLevel>(Cbx_ActivityLevel.SelectedValue.ToString(), out activityLevel);
                bool IsSterile; if (radiobtn_IsSterile.Checked == true)
                    IsSterile = true;
                else { IsSterile = false; }
                bool houseTrained; if (radiobtn_IsHouseTrained.Checked == true)
                    houseTrained = true;
                else { houseTrained = false; }

                string[] textboxes = new[] { name, breed };
                if (shelterManager.TextBoxValidation(textboxes) == true)
                {
                    dog = new Dog(name, shelter, Species.dog, age, gender, breed, houseTrained, IsSterile, activityLevel, desc, null);
                    dogmanager.NewDog(dog);
                    MessageBox.Show("Dog Added");
                }
                else
                {
                    MessageBox.Show("Some fields are empty. Please try again");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbx_DogName.Text = "Maverick";
            tbx_DogBreed.Text = "Labrador";
            richtbx_DogDesc.Text = "";
            cbx_DogGender.SelectedIndex = 0;
            cbx_DogShelter.SelectedIndex = 2;
            Cbx_ActivityLevel.SelectedIndex = 2;
            nud_DogAge.Value = 3;
            radiobtn_IsHouseTrained.Checked = true;
            radiobtn_IsSterile.Checked = true;
        }

        private void button_ViewAllDogs_Click(object sender, EventArgs e)
        {
            FillDogsFlowLayoutPanel();
        }
    }
}
