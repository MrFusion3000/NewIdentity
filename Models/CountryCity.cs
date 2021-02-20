using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class CountryCity
    {
        public int CountryCityID { get; set; }
        public int CityID { get; set; }
        public int CountryID { get; set; }

        public Country Country { get; set; }
        public City City { get; set; }
    }
}
