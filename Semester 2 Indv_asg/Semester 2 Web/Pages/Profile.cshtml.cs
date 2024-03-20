using Domain.Animals;
using Domain.enums;
using Domain.Users;
using Domain.CustomException;
using Logic.Counter;
using Logic.Services.Animals;
using Logic.Services.PaginationAndFilter;
using Logic.Services.UserService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Semester_2_Web.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        int pageSize = 4;
        public string PageTitle { get; private set; }
        private readonly AnimalManager animalManager;
        private readonly UserManager userManager;
        public User customer { get; set; }
        public string Msg { get; set; }
        public Pagination<Animal> paginationAnimal { get; set; }
        public PaginatedList<Animal> paginatedAnimals { get; set; }
        int Userid;

        //Binding Properties
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Firstname { get; set; }
        [BindProperty]
        public string lastname { get; set; }
        [BindProperty]
        public string Address { get; set; }
        [BindProperty]
        public DateTime Birthdate { get; set; }
        [BindProperty]
        public string SearchBy { get; set; }
        [BindProperty]
        public string SearchTerm { get; set; }
        [BindProperty]
        public string speciesFilter { get; set; }

        public ProfileModel(UserManager userManager, AnimalManager animalManager)
        {
            PageTitle = "Profile page";
            this.animalManager = animalManager;
            this.userManager = userManager;
        }

        public void OnGet(int pageIndex = 1, string SearchTerm = null, string SearchBy = null, string speciesFilter = null)
        {
            Userid = Convert.ToInt32(User.FindFirstValue("id"));
            paginationAnimal = new Pagination<Animal>(animalManager.GetAnimalsByAdopter(Userid), pageSize);
            try
            {
                this.SearchTerm = SearchTerm;
                this.SearchBy = SearchBy;
                this.speciesFilter = speciesFilter;

                switch (speciesFilter)
                {
                    case "empty":
                        paginationAnimal = new Pagination<Animal>(animalManager.GetAnimalsByAdopter(Userid), pageSize);
                        break;
                    case "cat":
                        paginationAnimal = new Pagination<Animal>(animalManager.GetSpeciesByAdopter(Species.cat, Userid), pageSize);
                        break;
                    case "dog":
                        paginationAnimal = new Pagination<Animal>(animalManager.GetSpeciesByAdopter(Species.dog, Userid), pageSize);
                        break;
                    case "bird":
                        paginationAnimal = new Pagination<Animal>(animalManager.GetSpeciesByAdopter(Species.bird, Userid), pageSize);
                        break;
                    case "hamster":
                        paginationAnimal = new Pagination<Animal>(animalManager.GetSpeciesByAdopter(Species.hamster, Userid), pageSize);
                        break;
                }

                Func<Animal, bool> func = null;
                if (!string.IsNullOrEmpty(SearchTerm))
                {
                    switch (SearchBy)
                    {
                        case "name":
                            func = animal => animal.name.Contains(SearchTerm, StringComparison.OrdinalIgnoreCase);
                            break;
                        case "shelter":
                            func = animal => animal.shelter.Contains(SearchTerm, StringComparison.OrdinalIgnoreCase);
                            break;
                    }

                }
                if (paginationAnimal != null)
                {
                    paginatedAnimals = paginationAnimal.GetPage(pageIndex, func);
                    var visiblePageNumbers = paginationAnimal.GetVisiblePageNumbers(pageIndex, paginatedAnimals.TotalPages, maxVisiblePages: 5);
                    ViewData["VisiblePageNumbers"] = visiblePageNumbers;
                }
            }
            catch(Exception ex) { Msg = "An error occured\n" + ex.Message; }
        }

        public IActionResult OnPost()
        {
            try
            {
                int Userid = Convert.ToInt32(User.FindFirst("id").Value);
                customer = userManager.GetUserByID(Userid);
                if (userManager.CheckAgeOver11(Birthdate) == true)
                {
                    string email = null; if (Email == customer.email)
                    { email = customer.email; } 
                    else if(Username != customer.username && userManager.CheckEmail(Email) == false)
                    { email = Email; }
                    string username = null; if (Username == customer.username)
                    { username = customer.username; }
                    else if (Username != customer.username && userManager.CheckUsername(Username) == false)
                    { username = Username; }

                    if (username != null && email != null)
                    {
                        User user = new User(Userid, email, false, username, customer.password, Firstname, lastname, Address, Birthdate);
                        userManager.UpdateUser(user);

                        List<Claim> claims = new List<Claim>();
                        claims.Add(new Claim("id", Userid.ToString()));
                        claims.Add(new Claim(ClaimTypes.Name, user.username));
                        claims.Add(new Claim("email", user.email));
                        claims.Add(new Claim("firstname", user.firstname));
                        claims.Add(new Claim("lastname", user.lastname));
                        claims.Add(new Claim("birthdate", user.birthdate.ToString()));
                        claims.Add(new Claim("address", user.address));

                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        HttpContext.SignOutAsync();
                        HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

                        return RedirectToPage("Profile");
                    }
                }
            }
            catch (UserException ex) 
            { 
                Msg = "Profile Not Updated\n"+ex.Message; return Page(); 
            }
            catch (DuplicateInputException ex)
            {
                Msg = "Profile Not Updated\n" + ex.Message;
                return Page();
            }
            catch (NotFoundException ex)
            {
                Msg = "Profile Not Updated\n" + ex.Message;
                return Page();
            }
            catch (AgeException ex)
            {
                Msg = "Profile Not Updated\n" + ex.Message;
                return Page();
            }
            return Page();
        }
    }
}