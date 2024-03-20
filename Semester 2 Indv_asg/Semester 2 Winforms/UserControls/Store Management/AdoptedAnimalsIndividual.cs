using Domain.Users;
using Logic.Services.Animals;
using Logic.Services.UserService;
using Repository.Database.Users;
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
    public partial class AdoptedAnimalsIndividual : UserControl
    {
        
        UserManager userManager;
        User user;
        Domain.Animals.Animal animal;
        AdoptedAnimalsControl adoptedAnimalsControl;
        public AdoptedAnimalsIndividual(Domain.Animals.Animal animal, AdoptedAnimalsControl adoptedAnimalsControl)
        {
            InitializeComponent();
            this.animal = animal;
            this.adoptedAnimalsControl = adoptedAnimalsControl;
            userManager = new UserManager(new UserDB());
            user = userManager.GetUserByID(animal.adopter_id);
            
            lbl_Animal.Text = $"Adopted Animal:\n{animal.name}\n Species:{animal.species}";
            lbl_Adopter.Text = $"Adopter:\n{user.firstname} {user.lastname}\n{user.address}";
        }
    }
}
