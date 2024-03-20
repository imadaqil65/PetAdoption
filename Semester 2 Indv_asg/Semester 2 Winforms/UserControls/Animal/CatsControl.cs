using Domain.Animals;
using Domain.Shelters;
using Domain.enums;
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
    public partial class CatsControl : UserControl
    {
        ShelterManager shelterManager;
        CatManager catmanager;
        Cat cat;

        public CatsControl()
        {
            InitializeComponent();
            catmanager = new CatManager(new CatDB());
            FillCatsFlowLayoutPanel();
            FillComboBoxes();
        }

        public void FillComboBoxes()
        {
            cbx_CatGender.DataSource = Enum.GetValues(typeof(Gender));
            shelterManager = new ShelterManager(new ShelterDB());
            cbx_CatShelter.DataSource = shelterManager.GetShelters();
            cbx_CatShelter.DisplayMember = "name";
            cbx_CatShelter.ValueMember = "id";
        }

        public void FillCatsFlowLayoutPanel()
        {
            try
            {
                flp_AvailableCats.Controls.Clear();
                foreach (var v in catmanager.GetCats())
                {
                    CatsIndividual I = new CatsIndividual(v, this);
                    flp_AvailableCats.Controls.Add(I);
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_AddCat_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbx_CatName.Text;
                int shelter = Convert.ToInt32(cbx_CatShelter.SelectedValue);
                int age = Convert.ToInt32(nud_CatAge.Value);
                Gender gender;
                Enum.TryParse<Gender>(cbx_CatGender.SelectedValue.ToString(), out gender);
                string desc = richtbx_CatDesc.Text;
                string breed = tbx_CatBreed.Text;
                string furcolor = tbx_CatFurColor.Text;
                string allergies = richtbx_CatAllergies.Text;
                bool IsSterile; if (radiobtn_CatSterile.Checked == true)
                { IsSterile = true; }
                else { IsSterile = false; }

                string[] textboxes = new[] { name, breed, furcolor, allergies };
                if (shelterManager.TextBoxValidation(textboxes) == true)
                {
                    cat = new Cat(name, shelter, Species.cat, age, gender, breed, furcolor, allergies, IsSterile, desc, null);
                    catmanager.NewCat(cat);
                    MessageBox.Show("Cat Added");
                }
                else
                {
                    MessageBox.Show("Some fields are empty. Please try again");
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbx_CatName.Text = "Anonym";
            tbx_CatBreed.Text = "Calico";
            tbx_CatFurColor.Text = "Mixed";
            richtbx_CatAllergies.Text = "Peanuts";
            richtbx_CatDesc.Text = "He likes to scratch sofas";
            cbx_CatGender.SelectedIndex = 0;
            cbx_CatShelter.SelectedIndex = 3;
            nud_CatAge.Value = 3;
            radiobtn_CatSterile.Checked = true;
        }

        private void button_ViewAllCats_Click(object sender, EventArgs e)
        {
            FillCatsFlowLayoutPanel();
        }
    }
}
