using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals.BirdService;
using Logic.Services.PaginationAndFilter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Semester_2_Web.Pages
{
    public class AdvancedFilterBirdsModel : PageModel
    {
        public Pagination<Bird> paginationAnimal { get; set; }
        public PaginatedList<Bird> paginatedAnimals { get; set; }
        public string Breed { get; set; }
        public Gender? Gender { get; set; }
        public ActivityLevel? ActivityLevel { get; set; }
        public bool Mimic { get; set; }
        public int MinWingspan { get; set; }
        public int MaxWingspan { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        private readonly BirdManager birdManager;
        private readonly Filter<Bird> BirdFilterHelper;
        public AdvancedFilterBirdsModel(BirdManager birdManager)
        {
            this.birdManager = birdManager;
            BirdFilterHelper = new Filter<Bird>(birdManager.GetBirds());
        }
        public void OnGet(string Breed, Gender? Gender, ActivityLevel? ActivityLevel, bool Mimic, int MinWingspan, int MaxWingspan, int MinAge, int MaxAge, int pageIndex = 1)
        {
            this.Breed = Breed;
            this.Gender = Gender;
            this.ActivityLevel = ActivityLevel;
            this.Mimic = Mimic;
            this.MinWingspan = MinWingspan;
            this.MaxWingspan = MaxWingspan;
            this.MinAge = MinAge;
            this.MaxAge = MaxAge;

            var filteredBirds = BirdFilterHelper.ApplyFilter(bird =>
            {
                bool matchesBreed = string.IsNullOrEmpty(Breed) || bird.breed.Contains(Breed, StringComparison.OrdinalIgnoreCase);
                bool matchesGender = Gender == null || bird.gender == Gender;
                bool matchesActivityLevel = ActivityLevel == null || bird.activityLevel == ActivityLevel;
                bool matchesMimic = Mimic == null || bird.voicemimic == Mimic;
                bool matchesWingspanRange = bird.wingspan >= MinWingspan && bird.wingspan <= MaxWingspan;
                bool matchesAgeRange = bird.age >= MinAge && bird.age <= MaxAge;

                return matchesBreed && matchesGender && matchesGender && matchesActivityLevel && matchesMimic && matchesWingspanRange && matchesAgeRange;
            });

            paginationAnimal = new Pagination<Bird>(filteredBirds, pageSize: 8);
            paginatedAnimals = paginationAnimal.GetPage(pageIndex);
            var visiblePageNumbers = paginationAnimal.GetVisiblePageNumbers(pageIndex, paginatedAnimals.TotalPages, maxVisiblePages: 5);
            ViewData["VisiblePageNumbers"] = visiblePageNumbers;
        }
    }
}
