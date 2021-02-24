using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Identity.Models.ViewModels
{
    public class CountriesVM
    {
        //public AppUser AppUser { get; set; }
        public static User User { get; set; }
        public Country Country { get; set; }
        public static City City { get; set; }


        // eventuell metod för att hämta CountryName filterat på CountryID 
    //    public string GetCountryName()
    //    {
    //        var result = from user in User.
    //                     join country in _context.Countries on user.CountryId equals country.CountryID
    //                     join city in _context.Cities on user.CityId equals city.CityID
    //                     select new { UserCountry = country.CountryName, UserCity = city.CityName

    //        return result;
    //};
//}

        //public List<SelectListItem> SelectListCountries { get; set; }


        //public int CountryID { get; set; }
        //public string CountryName { get; set; }

        //public IEnumerable<Country> Countries { get; set; }
        //public IEnumerable<City> Cities { get; set; }
    }
}
