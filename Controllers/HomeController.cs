using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly AppIdentityDbContext _context;

        public HomeController(UserManager<AppUser> usrMgr, AppIdentityDbContext context)
        {
            userManager = usrMgr;
            _context = context;

        }

        /*[Authorize]
        public IActionResult Index()
        {
            return View((object)"Hello");
        }*/

        //[Authorize(Roles = "Manager")]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            AppUser user = await userManager.GetUserAsync(HttpContext.User);
            //string message = "Hello " + user.UserName;
            AppUserDetailsViewModel.UsersList = userManager.Users.ToList();
            AppUserDetailsViewModel.CountriesList = _context.Countries.ToList();
            AppUserDetailsViewModel.CitiesList = _context.Cities.ToList();


            //return View(userManager.Users);
            return Redirect("~/Admin/Index");
        }
    }
}