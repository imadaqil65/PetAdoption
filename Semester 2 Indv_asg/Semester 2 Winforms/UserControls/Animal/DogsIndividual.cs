using Domain.Animals;
using Logic.Counter;
using Logic.Services.Animals.DogService;
using Repository.Database.Animals;

namespace Semester_2_Winforms.UserControls.Animal
{
    public partial class DogsIndividual : UserControl
    {
        Dog dog;
        DogsControl dogscontrol;
        DogManager dogManager;
        public DogsIndividual(Dog dog, DogsControl dogscontrol)
        {
            InitializeComponent();
            dogManager = new DogManager(new DogDB());
            this.dog = dog;
            this.dogscontrol = dogscontrol;

            lblName.Text = $"Name:\n{dog.name}";
            lblShelter.Text = $"Shelter:\n{dog.shelter}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormCounter.Formcounter == 0)
                {
                    FormCounter.Formcounter++;
                    this.BackColor = Color.Green;
                    Modify modify = new Modify(dog, this);
                    modify.Show();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "Are You Sure you want\nto delete this dog?", "Delete Dog", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    dogManager.DeleteDog(dog);
                    dogscontrol.Show();
                        break;
                case DialogResult.No: break;
            }
        }
    }
}
