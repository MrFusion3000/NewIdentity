using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public ICollection<CountryCity> CountryCities { get; set; }
    }
}
