using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class City
    {
        public int Id { get; set; }
        public int CityId { get; set; }

        //[ForeignKey("CityId")]
        //public AppUser AppUser { get; set; }
        public string CityName { get; set; }
        public int CountryCityID { get; set; }

        public static List<City> ShowCities { get; set; }

        //public virtual Country Country { get; set; }
    }
}
