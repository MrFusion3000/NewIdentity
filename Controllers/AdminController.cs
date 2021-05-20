using Microsoft.AspNetCore.Mvc;
using Identity.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Identity.Email;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Identity.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IPasswordHasher<AppUser> passwordHasher;
        private readonly IPasswordValidator<AppUser> passwordValidator;
        private readonly IUserValidator<AppUser> userValidator;
        private readonly AppIdentityDbContext _context;

        public AdminController(UserManager<AppUser> usrMgr, IPasswordHasher<AppUser> passwordHash, IPasswordValidator<AppUser> passwordVal, IUserValidator<AppUser> userValid, AppIdentityDbContext context)
        {
            userManager = usrMgr;
            passwordHasher = passwordHash;
            passwordValidator = passwordVal;
            userValidator = userValid;
            _context = context;
        }

        public IActionResult Index()
        {
            AppUserDetailsViewModel.UsersList = userManager.Users.ToList();
            AppUserDetailsViewModel.CountriesList = _context.Countries.ToList();
            AppUserDetailsViewModel.CitiesList = _context.Cities.ToList();

            return View(userManager.Users);
        }

        public IActionResult Role()
        {
            return Redirect("/Role/Index");
        }

        public IActionResult Claims()
        {
            return Redirect("/Claims/Index");
        }

        public ViewResult Create()
        {
            //var Countries = AppUserDetailsViewModel.CountriesList;

            List<SelectListItem> countries = new List<SelectListItem>();

            countries.Add(new SelectListItem { Text = "Select", Value = Guid.Empty.ToString(), Disabled=true });
            var countriesFilter = from country in _context.Countries
                                  select country;
            foreach (var item in countriesFilter)
            {
                countries.Add(new SelectListItem { Text = item.CountryName, Value = item.Id.ToString("D") });
            }

            ViewData["Countries"] = new SelectList(countries, "Id", "CountryName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    UserName = user.Name,
                    Email = user.Email,
                    CityId = user.CityId
                };

                IdentityResult result = await userManager.CreateAsync(appUser, user.Password);
                if (result.Succeeded)
                {
                    var token = await userManager.GenerateEmailConfirmationTokenAsync(appUser);
                    var confirmationLink = Url.Action("ConfirmEmail", "Email", new { token, email = user.Email }, Request.Scheme);
                    EmailHelper emailHelper = new EmailHelper();
                    bool emailResponse = emailHelper.SendEmail(user.Email, confirmationLink);

                    if (emailResponse)
                        return RedirectToAction("Index");
                    else
                    {
                        // log email failed 
                    }
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
            }
            return RedirectToAction("Index");

        }

        public ActionResult GetSelectedCity(string id)
        {
            List<SelectListItem> cities = new List<SelectListItem>();

            cities.Add(new SelectListItem { Text = "Select", Value = Guid.Empty.ToString(), Disabled=true });

            var citiesFilter = from city in _context.Cities
                               where city.CountryID == Guid.Parse(id)
                               select city;

            foreach (var item in citiesFilter)
            {
                cities.Add(new SelectListItem { Text = item.CityName, Value = item.Id.ToString("D") });
            }

            return Json(cities);
        }

        public async Task<IActionResult> Update(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                return View(user);
            }
            else
                return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(string id, string email, string password, Guid cityId)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult validEmail = null;
                if (!string.IsNullOrEmpty(email))
                {
                    validEmail = await userValidator.ValidateAsync(userManager, user);
                    if (validEmail.Succeeded)
                        user.Email = email;
                    else
                        Errors(validEmail);
                }
                else
                    ModelState.AddModelError("", "Email cannot be empty");

                IdentityResult validPass = null;
                if (!string.IsNullOrEmpty(password))
                {
                    validPass = await passwordValidator.ValidateAsync(userManager, user, password);
                    if (validPass.Succeeded)
                        user.PasswordHash = passwordHasher.HashPassword(user, password);
                    else
                        Errors(validPass);
                }
                else
                    ModelState.AddModelError("", "Password cannot be empty");

                user.CityId = cityId;

                if (validEmail != null && validPass != null && validEmail.Succeeded && validPass.Succeeded)
                {
                    IdentityResult result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                        Errors(result);
                }                
            }
            else
                ModelState.AddModelError("", "User Not Found");

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    Errors(result);
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return View("Index", userManager.Users);
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }
    }
}