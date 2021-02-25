using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Identity.Models.ViewModels
{
    public class CountriesVM
    {
        //public AppUser AppUser { get; set; }
        public AppUser User { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }



        //public static List<CountriesVM> UsersList { get; set; } = new List<CountriesVM>();
        //public static List<Country> CountriesList { get; set; }
        //public static List<City> CitiesList { get; set; }

        //public List<CountriesVM> TempUsersList { get; set; } = new List<CountriesVM>();


        
    }
}
