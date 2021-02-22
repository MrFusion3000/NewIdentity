using Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Views.ViewModels
{
    public class CountriesVM
    {
        public User User { get; set; }
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<City> Cities { get; set; }
    }
}
