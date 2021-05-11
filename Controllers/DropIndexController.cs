using Identity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Controllers
{
    public class DropIndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Edit()
        {
            var objProduct = new UserCountriesCitiesVM();
            objProduct.Countries = new[]
            {
              new SelectListItem { Value = "1", Text = "Perfume" },
              new SelectListItem { Value = "2", Text = "Shoe" },
              new SelectListItem { Value = "3", Text = "Shirt" }
            };
            objProduct.Cities = new[] { new SelectListItem { Value = "", Text = "" } };
            return View(objProduct);
        }

        public ActionResult GetSub(int id)
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem() { Text = "Sub Item 1", Value = "1" });
            items.Add(new SelectListItem() { Text = "Sub Item 2", Value = "8" });
            // you may replace the above code with data reading from database based on the id

            return Json(items);
        }
    }
}
