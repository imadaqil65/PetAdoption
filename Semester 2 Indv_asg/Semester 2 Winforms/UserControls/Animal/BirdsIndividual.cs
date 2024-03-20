using Domain.Animals;
using Logic.Counter;
using Logic.Services.Animals.BirdService;
using Logic.Services.Animals.DogService;
using Microsoft.VisualBasic.Logging;
using Repository.Database.Animals;
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
    public partial class BirdsIndividual : UserControl
    {
        Bird bird;
        BirdsControl birdsControl;
        BirdManager birdManager;

        public BirdsIndividual(Bird bird, BirdsControl birdsControl)
        {
            InitializeComponent();
            birdManager = new BirdManager(new BirdDB());
            this.bird = bird;
            this.birdsControl = birdsControl;

            lbl_Name.Text = $"Name:\n{bird.name}";
            lbl_Shelter.Text = $"Shelter\n{bird.shelter}";
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormCounter.Formcounter == 0)
                {
                    FormCounter.Formcounter++;
                    this.BackColor = Color.Green;
                    Modify modify = new Modify(bird, this);
                    modify.Show();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "Are You Sure you want\nto delete this bird?", "Delete Bird", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    birdManager.DeleteBird(bird);
                    //birdscontrol.Show();
                    break;
                case DialogResult.No: break;
            }
        }
    }
}
