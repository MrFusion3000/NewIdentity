using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        //public Country Country { get; set; }
        public int CountryId { get; set; }
        public virtual ICollection<Country> Country { get; set; }
    }
}
