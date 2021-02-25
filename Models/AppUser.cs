using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Identity.Models
{
    public class AppUser : IdentityUser
    {
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public int CityId { get; set; }        
        public virtual City City { get; set; }

        public string CountryName { get; internal set; }
        public string CityName { get; internal set; }

    }
}
