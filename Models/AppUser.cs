using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Identity.Models
{
    public class AppUser : IdentityUser
    {
        public int CountryId { get; set; }

        public int CityId { get; set; }

        //public static Country Country { get; set; }
        //public static City City { get; set; }


    }
}
