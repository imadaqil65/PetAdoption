using Domain.Animals;
using Logic.Counter;
using Logic.Services.Animals.CatService;
using Repository.Database.Animals;

namespace Semester_2_Winforms.UserControls
{
    public partial class CatsIndividual : UserControl
    {
        Cat cat;
        CatsControl catscontrol;
        CatManager catManager;
        public CatsIndividual(Cat cat, CatsControl catscontrol)
        {
            InitializeComponent();
            catManager = new CatManager(new CatDB());
            this.cat = cat;
            this.catscontrol = catscontrol;

            lblName.Text = $"Name:\n{cat.name}";
            lblShelter.Text = $"Shelter:\n{cat.shelter}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormCounter.Formcounter == 0)
                {
                    FormCounter.Formcounter++;
                    this.BackColor = Color.Green;
                    Modify modify = new Modify(cat, this);
                    modify.Show();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "Are You Sure you want\nto delete this cat?", "Delete Cat", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    catManager.DeleteCat(cat);
                    catscontrol.Show(); break;
                case DialogResult.No: break;
            }
        }
    }
}
