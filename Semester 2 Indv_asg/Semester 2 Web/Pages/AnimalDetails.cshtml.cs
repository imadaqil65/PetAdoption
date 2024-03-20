using Domain.Animals;
using Domain.enums;
using Domain.Shelters;
using Domain.Adoption;
using Logic.Services.Adoption;
using Logic.Services.Animals;
using Logic.Services.Animals.BirdService;
using Logic.Services.Animals.CatService;
using Logic.Services.Animals.DogService;
using Logic.Services.Animals.HamsterService;
using Logic.Services.ShelterService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Logic.Services.UserService;

namespace Semester_2_Web.Pages
{
    [Authorize]
    public class AnimalDetailsModel : PageModel
    {
        public PendingAdoption adoption { get; private set; }
        public Shelter shelter { get; private set; }
        public Animal animal { get; private set; }
        public Cat cat { get; private set; }
        public Dog dog { get; private set; }
        public Bird bird { get; private set; }
        public Hamster hamster { get; private set; }

        private readonly ShelterManager shelterManager;
        private readonly AnimalManager animalManager;
        private readonly CatManager catManager;
        private readonly DogManager dogManager;
        private readonly BirdManager birdManager;
        private readonly HamsterManager hamsterManager;
        private readonly PendingAdoptionManager adoptionManager;


        public AnimalDetailsModel(PendingAdoptionManager adoptionManager, ShelterManager shelterManager, AnimalManager animalManager, CatManager catManager, DogManager dogManager, BirdManager birdManager, HamsterManager hamsterManager)
        {
            this.adoptionManager = adoptionManager;
            this.shelterManager = shelterManager;
            this.animalManager = animalManager;
            this.catManager = catManager;
            this.dogManager = dogManager;
            this.birdManager = birdManager;
            this.hamsterManager = hamsterManager;
        }

        public void OnGet(int id)
        {
            animal = animalManager.GetAnimalById(id);
            shelter = shelterManager.GetShelterByID(animal.shelterid);
            if (animal.species == Species.cat)
            {
                cat = catManager.GetCat(id);
            }
            else if (animal.species == Species.dog)
            {
                dog = dogManager.GetDog(id);
            }
            else if (animal.species == Species.bird)
            {
                bird = birdManager.GetBirdByID(id);
            }
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            adoption = new PendingAdoption(Convert.ToInt32(User.FindFirst("id").Value), id);
            adoptionManager.NewAdoptionRequest(adoption);
            return new RedirectToPageResult("/Adopt");
        }
    }
}
