using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals.BirdService;
using Logic.Services.Animals.CatService;
using Logic.Services.ShelterService;
using Repository.Database.Animals;
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

namespace Semester_2_Winforms.UserControls
{
	public partial class BirdsControl : UserControl
	{
		Bird bird;
		BirdManager birdManager;
		ShelterManager shelterManager;
		public BirdsControl()
		{
			InitializeComponent();
			birdManager = new BirdManager(new BirdDB());
			FillComboBoxes();
            FillBirdsFlowLayoutPanel();
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
        public void FillBirdsFlowLayoutPanel()
        {
            try
            {
                flp_AvailableBirds.Controls.Clear();
                foreach (var v in birdManager.GetBirds())
                {
                    BirdsIndividual I = new BirdsIndividual(v, this);
                    flp_AvailableBirds.Controls.Add(I);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_AddBird_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbx_BirdName.Text;
                int shelter = Convert.ToInt32(cbx_BirdShelter.SelectedValue);
                int age = Convert.ToInt32(nud_BirdAge.Value);
                Gender gender;
                Enum.TryParse<Gender>(cbx_BirdGender.SelectedValue.ToString(), out gender);
                string desc = richtbx_BirdDesc.Text;
                string breed = tbx_BirdBreed.Text;
                ActivityLevel activityLevel;
                Enum.TryParse<ActivityLevel>(Cbx_ActivityLevel.SelectedValue.ToString(), out activityLevel);
                int wings = Convert.ToInt32(nud_Wingspan.Value);
                bool IsMimic; if (radiobtn_IsVoiceMimic.Checked == true)
                { IsMimic = true; }
                else { IsMimic = false; }
                string[] textboxes = new[] { name, breed };
                if (shelterManager.TextBoxValidation(textboxes) == true)
                {
                    bird = new Bird(name, shelter, Species.bird, age, gender, breed, IsMimic, wings, activityLevel, desc, null);
                    birdManager.CreateBird(bird);
                    MessageBox.Show("Bird Added");
                }
                else
                {
                    MessageBox.Show("some fields are empty. Try again");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button_ViewAllBirds_Click(object sender, EventArgs e)
        {
            FillBirdsFlowLayoutPanel(); 
        }
    }
}
