using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals.BirdService;
using Logic.Services.ShelterService;
using Repository.Database.Shelters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_2_Winforms.UserControls.Animal.ModifyAnimal
{
    public partial class ModifyBird : UserControl
    {
        Bird bird;
        BirdsIndividual birdsIndividual;
        BirdManager birdManager;
        ShelterManager shelterManager;

        public ModifyBird(Bird bird, BirdsIndividual birdsIndividual)
        {
            InitializeComponent();
            this.bird = bird;
            this.birdsIndividual = birdsIndividual;
            FillComboBoxes();
        }

        public void FillComboBoxes()
        {
            cbx_BirdGender.DataSource = Enum.GetValues(typeof(Gender));
            Cbx_ActivityLevel.DataSource = Enum.GetValues(typeof(ActivityLevel));
            shelterManager = new ShelterManager(new ShelterDB());
            cbx_BirdShelter.DataSource = shelterManager.GetShelters();
            cbx_BirdShelter.DisplayMember = "name";
            cbx_BirdShelter.ValueMember = "id";
        }

        public void FillBirdData()
        {
            tbx_BirdName.Text = bird.name;
            tbx_BirdBreed.Text = bird.breed;
            richtbx_BirdDesc.Text = bird.description;
            nud_BirdAge.Value = bird.age;
            nud_Wingspan.Value = bird.wingspan;
            cbx_BirdGender.SelectedItem = bird.gender;
            Cbx_ActivityLevel.SelectedItem = bird.activityLevel;
            cbx_BirdShelter.SelectedValue = bird.shelter;
            if (bird.voicemimic == true)
            { radiobtn_IsVoiceMimic.Checked = true; }
            else { radiobtn_NotVoiceMimic.Checked = true; }
        }

        private void btn_AddBird_Click(object sender, EventArgs e)
        {
            bird.name = tbx_BirdName.Text;
            bird.shelterid = Convert.ToInt32(cbx_BirdShelter.SelectedValue);
            bird.age = Convert.ToInt32(nud_BirdAge.Value);
            Gender gender;
            Enum.TryParse<Gender>(cbx_BirdGender.SelectedValue.ToString(), out gender);
            bird.gender = gender;
            bird.description = richtbx_BirdDesc.Text;
            bird.breed = tbx_BirdBreed.Text;
            ActivityLevel activityLevel;
            Enum.TryParse<ActivityLevel>(Cbx_ActivityLevel.SelectedValue.ToString(), out activityLevel);
            bird.activityLevel = activityLevel;
            bird.wingspan = Convert.ToInt32(nud_Wingspan.Value);
            bool IsMimic; if (radiobtn_IsVoiceMimic.Checked == true)
            { IsMimic = true; } else { IsMimic = false; }
            bird.voicemimic = IsMimic;
            string[] textboxes = new[] { tbx_BirdName.Text, tbx_BirdBreed.Text };
            if (shelterManager.TextBoxValidation(textboxes) == true)
            {
                birdManager.UpdateBird(bird);
                MessageBox.Show("Bird Modified");
            }
            else
            {
                MessageBox.Show("some fields are empty. Try again");
            }
        }
    }
}
