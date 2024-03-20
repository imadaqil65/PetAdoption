using Domain.Shelters;
using Logic.Services.ShelterService;
using Repository.Database.Shelters;
using Semester_2_Winforms.UserControls.Store_Management;
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
    public partial class ModifyShelter : UserControl
    {
        Shelter shelter;
        ShelterIndividual shelterIndividual;
        ShelterManager shelterManager;
        public ModifyShelter(Shelter shelter, ShelterIndividual shelterIndividual)
        {
            InitializeComponent();
            this.shelter = shelter;
            this.shelterIndividual = shelterIndividual;
            shelterManager = new ShelterManager(new ShelterDB());

            tbx_ShelterName.Text = shelter.name;
            tbx_LocationCity.Text = shelter.location;
            richtbx_Address.Text = shelter.address;
        }

        private void btn_EditShelter_Click(object sender, EventArgs e)
        {
            try
            {
                shelter.name = tbx_ShelterName.Text;
                shelter.location = tbx_LocationCity.Text;
                shelter.address = richtbx_Address.Text;
                string[] textboxes = new[] { tbx_ShelterName.Text, tbx_LocationCity.Text, richtbx_Address.Text };
                if (shelterManager.TextBoxValidation(textboxes) == true)
                {
                    shelterManager.UpdateShelter(shelter);
                    MessageBox.Show("Shelter Updated");
                }else { MessageBox.Show("Some fields are empty. Please try again"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
