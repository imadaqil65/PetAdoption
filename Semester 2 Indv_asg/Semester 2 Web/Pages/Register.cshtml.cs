using Domain.Users;
using Logic.Hashing;
using Logic.Counter;
using Logic.Services.UserService;
using Repository.Database.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Org.BouncyCastle.Crypto.Operators;
using Microsoft.AspNetCore.Authorization;
using Domain.CustomException;

namespace Semester_2_Web.Pages
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly UserManager usermanager;
        public RegisterModel(UserManager usermanager)
        {
            this.usermanager = usermanager;
        }

        public string Msg;
        
        [BindProperty] 
        public string email { get; set; }
        [BindProperty] 
        public string username { get; set; }
        [BindProperty]
        public string password { get; set; }
        [BindProperty]
        [Compare("password", ErrorMessage = "Confirm password doesn't match!")]
        public string confirmpassword { get; set; }
        [BindProperty]
        public string Firstname { get; set; }
        [BindProperty]
        public string Lastname { get; set; }
        [BindProperty]
        public string Address { get; set; }
        [BindProperty]
        public DateTime Birthdate { get; set; }
        public User user;

        public IActionResult OnGet() { if (User.Identity.IsAuthenticated) { return RedirectToPage("Index"); } return Page(); }

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (ModelState.IsValid && usermanager.CheckEmail(email) == false && usermanager.CheckUsername(username) == false  && password.Length > 7 && usermanager.CheckAgeOver11(Birthdate) == true)
                {
                    string hashedpw = usermanager.HashPassword(password);
                    user = new User(0, email, false, username, hashedpw, Firstname, Lastname, Address, Birthdate);

                    usermanager.NewUser(user);
                    return new RedirectToPageResult("/Login");
                }
                else if (password.Length < 8)
                {
                    Msg = "Password needs to be at least 8 characters";
                    return Page();
                }
            }
            catch (UserException ex)
            {
                Msg = ex.Message;
                return Page();
            }
            catch (DuplicateInputException ex)
            {
                Msg = ex.Message;
                return Page();
            }
            catch (NotFoundException ex)
            {
                Msg = ex.Message;
                return Page();
            }
            catch (AgeException ex)
            {
                Msg = ex.Message;
                return Page();
            }
            return null;
        }
    }
}
