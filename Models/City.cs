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
        public Guid Id { get; set; }
        public string CityName { get; set; }
        public Guid CountryID { get; set; }
    }
}
