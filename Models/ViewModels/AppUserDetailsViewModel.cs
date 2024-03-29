﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Identity.Models
{
    public class AppUserDetailsViewModel
    {
        //public AppUser AppUser { get; set; }
        public AppUser ListUser { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }

        public static List<AppUser> UsersList { get; set; }
        public static List<Country> CountriesList { get; set; }
        public static List<City> CitiesList { get; set; }

    }
}
