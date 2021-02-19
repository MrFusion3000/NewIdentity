using Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Views.ViewModels
{
    public class CountriesVM
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public List<City> Cities { get; set; }
    }
}
