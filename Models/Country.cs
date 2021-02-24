using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public static List<Country> ShowCountries { get; set; }

        //public virtual ICollection<City> Cities { get; set; }

        //public List<City> Getcities(int countryId)
        //{
        //    var CityList = Models.City.ShowCities
        //        .Where (x => x.CountrysID == CountryID)
        //        .ToList();
        //    return CityList;
        //}

        //        public virtual City Cities { get; set; }

    }
}
