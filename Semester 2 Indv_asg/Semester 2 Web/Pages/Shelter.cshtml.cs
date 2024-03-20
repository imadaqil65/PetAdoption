using Domain.Shelters;
using Logic.Services.PaginationAndFilter;
using Logic.Services.ShelterService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Semester_2_Web.Pages
{
    public class ShelterModel : PageModel
    {
        public string SearchTerm { get; set; }
        private readonly ShelterManager shelterManager;
        private readonly Pagination<Shelter> shelters;
        public PaginatedList<Shelter> ListShelters { get; set; }

        public ShelterModel(ShelterManager shelterManager)
        {
            this.shelterManager = shelterManager;
            shelters = new Pagination<Shelter>(shelterManager.GetShelters(), 8);
        }

        public void OnGet(int pageIndex = 1, string SearchTerm = null)
        {
            this.SearchTerm = SearchTerm;
            Func<Shelter, bool> searchfilter = null;
            if (!string.IsNullOrEmpty(SearchTerm))
            {
                searchfilter = shelter => shelter.location.Contains(SearchTerm, StringComparison.OrdinalIgnoreCase) || 
                shelter.name.Contains(SearchTerm, StringComparison.OrdinalIgnoreCase) || 
                shelter.address.Contains(SearchTerm, StringComparison.OrdinalIgnoreCase);
            }
            ListShelters = shelters.GetPage(pageIndex, searchfilter);
            var visiblePageNumbers = shelters.GetVisiblePageNumbers(pageIndex, ListShelters.TotalPages, 5);
            ViewData["VisiblePageNumbers"] = visiblePageNumbers;
        }
    }
}
