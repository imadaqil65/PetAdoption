using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals.DogService;
using Logic.Services.PaginationAndFilter;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Semester_2_Web.Pages
{
    public class AdvancedFilterDogsModel : PageModel
    {
        public Pagination<Dog> paginationAnimal { get; set; }
        public PaginatedList<Dog> paginatedAnimals { get; set; }
        public string Breed { get; set; }
        public Gender? Gender { get; set; }
        public ActivityLevel? ActivityLevel { get; set; }
        public bool Housetrained { get; set; }
        public bool Sterile { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        private readonly DogManager dogManager;
        private readonly Filter<Dog> DogFilterHelper;
        public AdvancedFilterDogsModel(DogManager dogManager)
        {
            this.dogManager = dogManager;
            DogFilterHelper = new Filter<Dog>(dogManager.GetDogs());
        }

        public void OnGet(string Breed, Gender? Gender, ActivityLevel? ActivityLevel, bool Housetrained, bool Sterile, int MinAge, int MaxAge, int pageIndex = 1)
        {
            this.Breed = Breed;
            this.Gender = Gender;
            this.ActivityLevel = ActivityLevel;
            this.Housetrained = Housetrained;
            this.Sterile = Sterile;
            this.MinAge = MinAge;
            this.MaxAge = MaxAge;

            var filteredDogs = DogFilterHelper.ApplyFilter(dog =>
            {
                bool matchesBreed = string.IsNullOrEmpty(Breed) || dog.breed.Contains(Breed, StringComparison.OrdinalIgnoreCase);
                bool matchesGender = Gender == null || dog.gender == Gender;
                bool matchesActivityLevel = ActivityLevel == null || dog.activityLevel == ActivityLevel;
                bool matchesHousetrained = Housetrained == null || dog.housetrained == Housetrained;
                bool matchesSterile = Sterile == null || dog.sterile == Sterile;
                bool matchesAgeRange = dog.age >= MinAge && dog.age <= MaxAge;

                return matchesBreed && matchesGender && matchesActivityLevel && matchesHousetrained && matchesSterile && matchesAgeRange;
            }
            ).ToList();

            paginationAnimal = new Pagination<Dog>(filteredDogs, pageSize: 8);
            paginatedAnimals = paginationAnimal.GetPage(pageIndex);
            var visiblePageNumbers = paginationAnimal.GetVisiblePageNumbers(pageIndex, paginatedAnimals.TotalPages, maxVisiblePages: 5);
            ViewData["VisiblePageNumbers"] = visiblePageNumbers;
        }
    }
}
