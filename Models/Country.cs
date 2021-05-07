using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Identity.Models
{
    public class Country
    {
        public Guid Id { get; set; }
        public string CountryName { get; set; }
    }
}
