using Domain.Animals;
using Domain.Users;
using Domain.Shelters;
using Logic.Services.Animals;
using Logic.Services.ShelterService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Org.BouncyCastle.Security;
using Logic.Services.UserService;

namespace Semester_2_Web.Pages
{
    public class AdoptModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
