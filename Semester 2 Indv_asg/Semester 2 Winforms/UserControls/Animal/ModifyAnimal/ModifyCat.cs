using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals.CatService;
using Logic.Services.ShelterService;
using Repository.Database.Animals;
using Repository.Database.Shelters;
using System.Drawing.Drawing2D;
using System.Xml.Linq;

namespace Semester_2_Winforms.UserControls.Animal.ModifyAnimal
{
    public partial class ModifyCat : UserControl
    {
        Cat cat;
        CatsIndividual catsIndividual;
        CatManager catManager;
        ShelterManager shelterManager;

        public ModifyCat(Cat cat, CatsIndividual catsIndividual)
        {
            InitializeComponent();
            this.cat = cat;
            this.catsIndividual = catsIndividual;
            catManager = new CatManager(new CatDB());
            FillComboBoxes();
            FillCatDetails();
        }

        public void FillComboBoxes()
        {
            cbx_CatGender.DataSource = Enum.GetValues(typeof(Gender));
            shelterManager = new ShelterManager(new ShelterDB());
            cbx_CatShelter.DataSource = shelterManager.GetShelters();
            cbx_CatShelter.DisplayMember = "name";
            cbx_CatShelter.ValueMember = "id";
        }

        public void FillCatDetails()
        {
            try
            {
                tbx_CatName.Text = cat.name;
                nud_CatAge.Value = cat.age;
                cbx_CatGender.SelectedItem = cat.gender;
                cbx_CatShelter.SelectedValue = cat.shelterid;
                richtbx_CatDesc.Text = cat.description;
                tbx_CatBreed.Text = cat.breed;
                tbx_CatFurColor.Text = cat.furcolor;
                richtbx_CatAllergies.Text = cat.allergies;
                if (cat.IsSterile == true) { radiobtn_CatSterile.Checked = true; } else { radiobtn_CatNotSterile.Checked = true; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_AddCat_Click(object sender, EventArgs e)
        {
            try
            {
                cat.name = tbx_CatName.Text;
                cat.shelterid = Convert.ToInt32(cbx_CatShelter.SelectedValue);
                cat.age = Convert.ToInt32(nud_CatAge.Value);
                Gender gender;
                Enum.TryParse<Gender>(cbx_CatGender.SelectedValue.ToString(), out gender);
                cat.gender = gender;
                cat.description = richtbx_CatDesc.Text;
                cat.breed = tbx_CatBreed.Text;
                cat.furcolor = tbx_CatFurColor.Text;
                cat.allergies = richtbx_CatAllergies.Text;
                bool IsSterile; if (radiobtn_CatSterile.Checked == true)
                { IsSterile = true; }
                else { IsSterile = false; }
                cat.IsSterile = IsSterile;

                string[] textboxes = new[] { tbx_CatName.Text, tbx_CatBreed.Text, tbx_CatFurColor.Text, richtbx_CatAllergies.Text };
                if (shelterManager.TextBoxValidation(textboxes) == true)
                {
                    catManager.UpdateCat(cat);
                    MessageBox.Show("Cat Modified");
                }
                else { MessageBox.Show("Some fields are empty. Please try again"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
