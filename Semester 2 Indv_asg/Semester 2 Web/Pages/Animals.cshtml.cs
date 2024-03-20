using Domain.Animals;
using Domain.enums;
using Domain.CustomException;
using Logic.Services.Animals;
using Logic.Services.PaginationAndFilter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository.Database.Animals;

namespace Semester_2_Web.Pages
{
    public class AnimalsModel : PageModel
    {
        public string PageTitle { get; private set; }
        private readonly AnimalManager animalManager;
        public Pagination<Animal> paginationAnimal { get; set; }
        public PaginatedList<Animal> paginatedAnimals { get; set; }
        public string Msg { get; set; }
        List<Animal> animals;
        [BindProperty]
        public string SearchBy { get; set; }
        [BindProperty]
        public string SearchTerm { get; set; }
        [BindProperty]
        public string speciesFilter { get; set; }

        public AnimalsModel(AnimalManager animalManager)
        {
            PageTitle = "Animal page";
            this.animalManager = animalManager;
        }

        public void OnGet(int pageIndex = 1, string SearchTerm = null, string SearchBy = null, string speciesFilter = null)
        {
            try
            {
                this.SearchTerm = SearchTerm;
                this.SearchBy = SearchBy;
                this.speciesFilter = speciesFilter;
                animals = new List<Animal>();

                if (string.IsNullOrEmpty(speciesFilter))
                {
                    animals = animalManager.GetNonAdoptedAnimals();
                }
                else
                {
                    switch (speciesFilter)
                    {
                        case "empty":
                            animals = animalManager.GetNonAdoptedAnimals();
                            break;
                        case "cat":
                            animals = animalManager.GetNonAdoptedSpecies(Species.cat);
                            break;
                        case "dog":
                            animals = animalManager.GetNonAdoptedSpecies(Species.dog);
                            break;
                        case "bird":
                            animals = animalManager.GetNonAdoptedSpecies(Species.bird);
                            break;
                    }
                }
                Func<Animal, bool> searchFilter = null;
                if (!string.IsNullOrEmpty(SearchTerm) && !string.IsNullOrEmpty(SearchBy))
                {
                    //Func<Animal, bool> searchFilter = null;

                    switch (SearchBy)
                    {
                        case "name":
                            searchFilter = animal => animal.name.Contains(SearchTerm, StringComparison.OrdinalIgnoreCase);
                            break;
                        case "shelter":
                            searchFilter = animal => animal.shelter.Contains(SearchTerm, StringComparison.OrdinalIgnoreCase);
                            break;
                    }
                }

                paginationAnimal = new Pagination<Animal>(animals, pageSize: 8);
                paginatedAnimals = paginationAnimal.GetPage(pageIndex, searchFilter);
                var visiblePageNumbers = paginationAnimal.GetVisiblePageNumbers(pageIndex, paginatedAnimals.TotalPages, maxVisiblePages: 5);
                ViewData["VisiblePageNumbers"] = visiblePageNumbers;
            }
            catch (NoConnectionException ex)
            {
                Msg = ex.Message;
            }
        }
    }
}
