using Domain.Animals;
using Domain.Shelters;
using Logic.Counter;
using Logic.Services.Animals.DogService;
using Logic.Services.ShelterService;
using Microsoft.VisualBasic.Logging;
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

namespace Semester_2_Winforms.UserControls.Store_Management
{
    public partial class ShelterIndividual : UserControl
    {
        Shelter shelter;
        ShelterControl shelterControl;
        ShelterManager shelterManager;
        public ShelterIndividual(Shelter shelter, ShelterControl shelterControl)
        {
            InitializeComponent();
            this.shelter = shelter;
            this.shelterControl = shelterControl;
            shelterManager = new ShelterManager(new ShelterDB());
            lbl_ShelterName.Text = "Name:\n"+shelter.name;
            lbl_location.Text = $"Address:\n{shelter.address},\n{shelter.location}";
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormCounter.Formcounter == 0)
                {
                    FormCounter.Formcounter++;
                    this.BackColor = Color.Green;
                    Modify modify = new Modify(shelter, this);
                    modify.Show();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "Are You Sure you want\nto delete this shelter?", "Delete Shelter", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    shelterManager.DeleteShelter(shelter);
                    break;
                case DialogResult.No: break;
            }
        }
    }
}
