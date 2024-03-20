using Logic.Services.Animals;
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

namespace Semester_2_Winforms.UserControls.Store_Management
{
    public partial class AdoptedAnimalsControl : UserControl
    {
        AnimalManager animalManager;
        public AdoptedAnimalsControl()
        {
            InitializeComponent();
            animalManager = new AnimalManager(new AnimalDB());
            FillFlowLayoutPanel();
        }

        public void FillFlowLayoutPanel()
        {
            flp_AdoptionRequests.Controls.Clear();
            foreach (var v in animalManager.GetAdoptedAnimals())
            {
                AdoptedAnimalsIndividual I = new AdoptedAnimalsIndividual(v, this);
                flp_AdoptionRequests.Controls.Add(I);
            }
        }
    }
}
