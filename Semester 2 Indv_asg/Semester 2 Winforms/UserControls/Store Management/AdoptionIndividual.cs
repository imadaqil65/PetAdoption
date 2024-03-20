using Domain.Animals;
using Domain.Adoption;
using Domain.enums;
using Logic.Services.Adoption;
using Logic.Services.Animals;
using Repository.Database.Adoption;
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
using Logic.Services.Animals.CatService;
using Logic.Services.Animals.DogService;
using Logic.Services.Animals.BirdService;
using Logic.Services.Animals.HamsterService;

namespace Semester_2_Winforms.UserControls.Store_Management
{
    public partial class AdoptionIndividual : UserControl
    {
        PendingAdoptionManager AdoptionManager;
        AnimalManager animalManager;
        PendingAdoption pendingAdoption;
        AdoptionControl adoptionControl;


        public AdoptionIndividual(PendingAdoption pendingAdoption, AdoptionControl adoptionControl)
        {
            InitializeComponent();
            this.pendingAdoption = pendingAdoption;
            this.adoptionControl = adoptionControl;
            InstanciateManagers();

            lbl_Adopter.Text = $"{pendingAdoption.firstname} {pendingAdoption.lastname}";
            lbl_Animal.Text = $"{pendingAdoption.Animal_name} || {pendingAdoption.species}";
            lbl_shelter.Text = $"{pendingAdoption.sheltername}";
        }

        public void InstanciateManagers()
        {
            AdoptionManager = new PendingAdoptionManager(new PendingAdoptionDB());
            animalManager = new AnimalManager(new AnimalDB());
        }

        private void btn_FullDetails_Click(object sender, EventArgs e)
        {
            string Detail = $"> Requester\nName: {pendingAdoption.firstname} {pendingAdoption.lastname}\nAddress: {pendingAdoption.customerAddress}" +
                $"\n> Requested Animal\nName: {pendingAdoption.Animal_name}\nSpecies:{pendingAdoption.species}\nShelter: {pendingAdoption.sheltername}" +
                $"\nAddress: {pendingAdoption.shelterAddress}";
            MessageBox.Show(Detail);
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            Domain.Animals.Animal animal = animalManager.GetAnimalById(pendingAdoption.Animal_id);
            animal.adopter_id = pendingAdoption.User_id;
            animal.isAdopted = true;
            animalManager.UpdateAnimal(animal);
            AdoptionManager.ApproveRequest(pendingAdoption);
        }

        private void btn_Decline_Click(object sender, EventArgs e)
        {
            AdoptionManager.DeleteAdoptionRequest(pendingAdoption);
        }
    }
}
