using Domain.Animals;
using Domain.Shelters;
using Logic.Counter;
using Logic.Services.Animals.CatService;
using Semester_2_Winforms.UserControls;
using Semester_2_Winforms.UserControls.Animal;
using Semester_2_Winforms.UserControls.Animal.ModifyAnimal;
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

namespace Semester_2_Winforms
{
    public partial class Modify : Form
    {
        Bird bird;
        BirdsIndividual birdsIndividual;    
        Cat cat;
        CatsIndividual catsIndividual;
        Dog dog;
        DogsIndividual dogsIndividual;
        Shelter shelter;
        ShelterIndividual shelterIndividual;

        private int isCat;

        public Modify(Cat cat, CatsIndividual catsIndividual)
        {
            InitializeComponent();
            this.cat = cat;
            this.catsIndividual = catsIndividual;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new ModifyCat(cat, catsIndividual));
            isCat = 0;
        }

        public Modify(Dog dog, DogsIndividual dogsIndividual)
        {
            InitializeComponent();
            this.dog = dog;
            this.dogsIndividual = dogsIndividual;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new ModifyDog(dog, dogsIndividual));
            isCat = 1;
        }

        public Modify(Shelter shelter, ShelterIndividual shelterIndividual)
        {
            InitializeComponent();
            this.shelter = shelter;
            this.shelterIndividual = shelterIndividual;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new ModifyShelter(shelter, shelterIndividual));
            isCat = 2;
        }

        public Modify(Bird bird, BirdsIndividual birdsIndividual)
        {
            InitializeComponent();
            this.bird = bird;
            this.birdsIndividual = birdsIndividual;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new ModifyBird(bird, birdsIndividual));
        }

        private void Modify_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isCat == 0)
            catsIndividual.BackColor = Color.AntiqueWhite;
            else if(isCat == 1)
            dogsIndividual.BackColor = Color.AntiqueWhite;
            else
            shelterIndividual.BackColor = Color.LightBlue;
            FormCounter.Formcounter--;
        }
    }
}
