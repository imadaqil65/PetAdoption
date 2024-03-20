using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Semester_2_Web.Pages
{
    [Authorize]
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            /*string returnUrl = HttpContext.Request.Path.ToString();
            HttpContext.Response.Cookies.Append("ReturnUrl", returnUrl);

            HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Home");*/

            HttpContext.SignOutAsync();

            return RedirectToPage("Index");
        }
    }
}
