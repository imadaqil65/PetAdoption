using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals.DogService;
using Logic.Services.ShelterService;
using Repository.Database.Animals;
using Repository.Database.Shelters;

namespace Semester_2_Winforms.UserControls.Animal.ModifyAnimal
{
    public partial class ModifyDog : UserControl
    {
        Dog dog;
        DogManager dogManager;
        DogsIndividual dogsIndividual;
        ShelterManager shelterManager;

        public ModifyDog(Dog dog, DogsIndividual dogsIndividual)
        {
            InitializeComponent();
            this.dog = dog;
            this.dogsIndividual = dogsIndividual;
            dogManager = new DogManager(new DogDB());
            FillComboBoxes();
            FillDogDetails();
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

        public void FillDogDetails()
        {
            try
            {
                tbx_DogName.Text = dog.name;
                nud_DogAge.Value = dog.age;
                cbx_DogGender.SelectedItem = dog.gender;
                cbx_DogShelter.SelectedValue = dog.shelterid;
                richtbx_DogDesc.Text = dog.description;
                tbx_DogBreed.Text = dog.breed;
                Cbx_ActivityLevel.SelectedItem = dog.activityLevel;
                if (dog.housetrained == true) { radiobtn_IsHouseTrained.Checked = true; } else { radiobtn_NotHouseTrained.Checked = true; }
                if (dog.sterile == true) { radiobtn_IsSterile.Checked = true; } else { radiobtn_NotSterile.Checked = true; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_AddDog_Click(object sender, EventArgs e)
        {
            try
            {
                dog.name = tbx_DogName.Text;
                dog.shelterid = Convert.ToInt32(cbx_DogShelter.SelectedValue);
                dog.age = Convert.ToInt32(nud_DogAge.Value);
                dog.description = richtbx_DogDesc.Text;
                dog.breed = tbx_DogBreed.Text;
                Gender gender;
                Enum.TryParse<Gender>(cbx_DogGender.SelectedValue.ToString(), out gender);
                dog.gender = gender;
                ActivityLevel activityLevel;
                Enum.TryParse<ActivityLevel>(Cbx_ActivityLevel.SelectedValue.ToString(), out activityLevel);
                dog.activityLevel = activityLevel;
                bool IsSterile; if (radiobtn_IsSterile.Checked == true)
                    IsSterile = true;
                else { IsSterile = false; }
                dog.sterile = IsSterile;
                bool houseTrained; if (radiobtn_IsHouseTrained.Checked == true)
                    houseTrained = true;
                else { houseTrained = false; }
                dog.housetrained = houseTrained;

                string[] textboxes = new[] { tbx_DogName.Text, tbx_DogBreed.Text };
                if (shelterManager.TextBoxValidation(textboxes) == true)
                {
                    dogManager.UpdateDog(dog);
                    MessageBox.Show("Dog Modified");
                } else { MessageBox.Show("Some fields are empty. Please try again"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
