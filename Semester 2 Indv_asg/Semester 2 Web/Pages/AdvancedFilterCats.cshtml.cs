using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals.CatService;
using Logic.Services.PaginationAndFilter;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Reflection;

namespace Semester_2_Web.Pages
{
    public class AdvancedFilterCatsModel : PageModel
    {
        public Pagination<Cat> paginationAnimal { get; set; }
        public PaginatedList<Cat> paginatedAnimals { get; set; }
        public string Breed { get; set; }
        public Gender? Gender { get; set; }
        public string Color { get; set; }
        public bool Sterile { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        private readonly CatManager catManager;
        private readonly Filter<Cat> CatFilterHelper;

        public AdvancedFilterCatsModel(CatManager catManager)
        {
            this.catManager = catManager;
            CatFilterHelper = new Filter<Cat>(catManager.GetCats());
        }
        public void OnGet(string Breed, Gender? Gender, string Color, bool Sterile, int MinAge, int MaxAge, int pageIndex = 1)
        {
            this.Breed = Breed;
            this.Gender = Gender;
            this.Color = Color;
            this.Sterile = Sterile;
            this.MinAge = MinAge;
            this.MaxAge = MaxAge;

            var filteredCats = CatFilterHelper.ApplyFilter(cat =>
            {
                bool matchesBreed = string.IsNullOrEmpty(Breed) || cat.breed.Contains(Breed, StringComparison.OrdinalIgnoreCase);
                bool matchesGender = Gender == null || cat.gender == Gender;
                bool matchesColor = string.IsNullOrEmpty(Color) || cat.furcolor.Contains(Color, StringComparison.OrdinalIgnoreCase);
                bool matchesSterile = Sterile == null || cat.IsSterile == Sterile;
                bool matchesAgeRange = cat.age >= MinAge && cat.age <= MaxAge;

                return matchesBreed && matchesGender && matchesColor && matchesSterile && matchesAgeRange;
            }).ToList();

            paginationAnimal = new Pagination<Cat>(filteredCats, pageSize: 8);
            paginatedAnimals = paginationAnimal.GetPage(pageIndex);
            var visiblePageNumbers = paginationAnimal.GetVisiblePageNumbers(pageIndex, paginatedAnimals.TotalPages, maxVisiblePages: 5);
            ViewData["VisiblePageNumbers"] = visiblePageNumbers;

        }
    }
}
