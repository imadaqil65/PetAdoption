using Logic.Services.Adoption;
using Repository.Database.Adoption;
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
    public partial class AdoptionControl : UserControl
    {
        PendingAdoptionManager adoptionManager;
        public AdoptionControl()
        {
            InitializeComponent();
            adoptionManager = new PendingAdoptionManager(new PendingAdoptionDB());
            FillFlowLayoutPanel();
        }

        public void FillFlowLayoutPanel()
        {
            flp_AdoptionRequests.Controls.Clear();
            foreach (var v in adoptionManager.GetAdoptionRequests())
            {
                AdoptionIndividual I = new AdoptionIndividual(v, this);
                flp_AdoptionRequests.Controls.Add(I);
            }
        }

        private void btn_ViewAllRequests_Click(object sender, EventArgs e)
        {
            FillFlowLayoutPanel();
        }
    }
}
