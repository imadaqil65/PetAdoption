using Domain.Animals;
using Domain.enums;
using Logic.Services.Animals.BirdService;
using Logic.Services.Animals.CatService;
using Logic.Services.Animals.DogService;
using Logic.Services.PaginationAndFilter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace Semester_2_Web.Pages
{
    public class AdvancedFilterModel : PageModel
    {
        [BindProperty]
        public string Species { get; set; }
        [BindProperty]
        public Gender gender { get; set; }
        [BindProperty]
        public int MinAge { get; set; }
        [BindProperty]
        public int MaxAge { get; set; }
        [BindProperty]
        public string Breed { get; set; }
        [BindProperty]
        public ActivityLevel Level { get; set; }
        [BindProperty]
        public bool Housetrained { get; set; }
        [BindProperty]
        public bool Sterile { get; set; }
        [BindProperty]
        public string Color { get; set; }
        [BindProperty]
        public bool Mimic { get; set; }
        [BindProperty]
        public int MinWingspan { get; set; }
        [BindProperty]
        public int MaxWingspan { get; set; }

        public IActionResult OnPost()
        {
            if (Species == "Dog")
            {
                return RedirectToPage("AdvancedFilterDogs", new
                {
                    Breed = Breed,
                    Gender = gender,
                    ActivityLevel = Level,
                    Housetrained = Housetrained,
                    Sterile = Sterile,
                    MinAge = MinAge,
                    MaxAge = MaxAge
                });

            }
            else if (Species == "Cat")
            {
                return RedirectToPage("AdvancedFilterCats", new
                {
                    Breed = Breed,
                    Gender = gender,
                    Color = Color,
                    Sterile = Sterile,
                    MinAge = MinAge,
                    MaxAge = MaxAge
                });
            }
            else if (Species == "Bird")
            {
                return RedirectToPage("AdvancedFilterBirds", new
                {
                    Breed = Breed,
                    Gender = gender,
                    ActivityLevel = Level,
                    Mimic = Mimic,
                    MinWingspan = MinWingspan,
                    MaxWingspan = MaxWingspan,
                    MinAge = MinAge,
                    MaxAge = MaxAge
                });
            }
            return null;
        }
        public void OnGet()
        {

        }
    }
}
