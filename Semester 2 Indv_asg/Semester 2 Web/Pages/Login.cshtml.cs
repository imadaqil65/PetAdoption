using Domain.CustomException;
using Domain.Users;
using Logic.Services.UserService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Semester_2_Web.Pages
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager usermanager;

        public LoginModel(UserManager usermanager)
        {
            this.usermanager = usermanager;
        }

        public string Msg { get; set; }
        [BindProperty] public string Username { get; set; }
        [BindProperty] public string Password { get; set; }
        public int? ID { get; set; }
        public User customer { get; set; }

        public IActionResult OnGet() 
        { 
            if (User.Identity.IsAuthenticated) 
            { 
                return RedirectToPage("Index"); 
            } 
            return Page(); 
        }

        public IActionResult OnPost(string? returnUrl)
        {
            try
            {
                if (ModelState.IsValid && usermanager.CheckUsername(Username) == true && usermanager.VerifyPassword(Password, Username) == true)
                {
                    ID = usermanager.GetID(Username);
                    customer = usermanager.GetUserByID(ID);
                    if (customer.IsAdmin == false)
                    {
                        List<Claim> claims = new List<Claim>();
                        claims.Add(new Claim("id", ID.ToString()));
                        claims.Add(new Claim(ClaimTypes.Name, customer.username));
                        claims.Add(new Claim("email", customer.email));
                        claims.Add(new Claim("firstname", customer.firstname));
                        claims.Add(new Claim("lastname", customer.lastname));
                        claims.Add(new Claim("birthdate", customer.birthdate.ToString()));
                        claims.Add(new Claim("address", customer.address));
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
                        if (!String.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                        {
                            return Redirect(returnUrl);
                        }
                        else
                        {
                            return RedirectToPage("Index");
                        }
                    }
                    else
                    {
                        Msg = "Admin cannot log in to website";
                        return Page();
                    }
                }
                else
                {
                    Msg = "Credentials invalid";
                    return Page();
                }
            }
            catch (UserException ex)
            {
                Msg = ex.Message;
                return Page();
            }
            catch (Exception ex)
            {
                Msg = ex.Message;
                return Page();
            }
        }
    }
}
