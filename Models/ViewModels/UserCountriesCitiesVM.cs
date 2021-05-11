using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Identity.Models
{
    public class UserCountriesCitiesVM
    {
        //public AppUser AppUser { get; set; }
        //public User User { get; set; }
        //public Country Country { get; set; }
        //public City City { get; set; }

        //public static List<CountriesVM> UsersList { get; set; } = new List<CountriesVM>();
        public int ProductId { get; set; }
        public IEnumerable<SelectListItem> Countries { get; set; }
        public string SelectedMainCatId { get; set; }
        public IEnumerable<SelectListItem> Cities { get; set; }
        public string SelectedSubCatId { get; set; }

        //public static List<City> CitiesList { get; set; }

        //public List<CountriesVM> TempUsersList { get; set; } = new List<CountriesVM>();



    }
}
