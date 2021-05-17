using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Identity.Models
{
    public class AppUser : IdentityUser
    {
        //public Guid CountryId { get; set; }
        //public virtual Country Country { get; set; }
        public Guid CityId { get; set; }
        //public virtual City City { get; set; }

        [NotMapped]
        public string CountryName { get; internal set; }
        [NotMapped]
        public string CityName { get; internal set; }
    }
}
