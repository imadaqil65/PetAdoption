using Domain.Shelters;
using Logic.Services.ShelterService;
using Repository.Database.Shelters;

namespace Semester_2_Winforms.UserControls.Store_Management
{
    public partial class ShelterControl : UserControl
    {
        ShelterManager shelterManager;
        public ShelterControl()
        {
            InitializeComponent();
            shelterManager = new ShelterManager(new ShelterDB());
            FillFlowLayoutPanel();
        }

        public void FillFlowLayoutPanel()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var v in shelterManager.GetShelters())
            {
                ShelterIndividual I = new ShelterIndividual(v, this);
                flowLayoutPanel1.Controls.Add(I);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            FillFlowLayoutPanel();
        }

        private void btn_CreateShelter_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbx_ShelterName.Text;
                string location = tbx_LocationCity.Text;
                string address = richtbx_Address.Text;

                string[] textboxes = new[] { name, location, address };
                if (shelterManager.TextBoxValidation(textboxes) == true)
                {
                    Shelter shelter = new Shelter(name, location, address);
                    shelterManager.NewShelter(shelter);
                    MessageBox.Show("Shelter Added");
                    FillFlowLayoutPanel();
                }
                else { MessageBox.Show("Some fields are empty. Please try again"); }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
