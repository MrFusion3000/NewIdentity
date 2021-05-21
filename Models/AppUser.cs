using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Identity.Models
{
    public class AppUser : IdentityUser
    {
        public Guid CityId { get; set; }
        
        //[NotMapped]
        //public Guid CountryId { get; internal set; }
        
        [NotMapped]
        public string CountryName { get; internal set; }
        [NotMapped]
        public string CityName { get; internal set; }

    }
}
