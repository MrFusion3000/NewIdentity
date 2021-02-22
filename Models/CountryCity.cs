using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class CountryCity
    {
        public int CountryCityID { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }

        public Country Country { get; set; }
        public City City { get; set; }
    }
}
