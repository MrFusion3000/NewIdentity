using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public Guid CityId { get; set; }
        public IEnumerable<SelectListItem> City { get; set; }
        [Required]
        public Guid CountryId { get; set; }
        public IEnumerable<SelectListItem> Country { get; set; }


        public virtual Country Countries { get; set; }
        public virtual City Cities { get; set; }

    }
}
