using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public static class DbInitializer
    {
        public static void Initialize(AppIdentityDbContext context)
        {
            //context.Database.EnsureCreated();
            //context.Database.Migrate(); ;

            //string COUNTRY_ID1 = "02s74cs0 – 9515 – 4cae - afaf - 595706d62cf6";
            //string COUNTRY_ID2 = "02574c40 – 9413 – 4cae - afaf - 595706d62cf2";
            //string INIT_ID =   "00000000 - 0000 - 0000 - 0000 - 000000000000";
            //var CountryGuid1 = Guid.Parse(COUNTRY_ID1);
            //var CountryGuid2 = Guid.Parse(COUNTRY_ID2);
            ////var CityInitGuid = Guid.Parse(INIT_ID);

            // Look for any Countries
            //if (context.Cities.Any())
            //{
            //    return;   // DB has been seeded
            //}

            // Add sample countries
            //var countries = new Country[]
            //{
            //new Country{Id = CountryGuid1, CountryName = "Sweden"},
            //new Country{Id = CountryGuid2, CountryName= "Norway"}

            //};
            //foreach (Country s in countries)
            //{
            //    context.Countries.Add(s);
            //}
            //context.SaveChanges();

            //Add sample Cities
            //    var cities = new City[]
            //    {
            //        new City{CityName="Select", CountryID = CityInitGuid},
            //        new City{CityName="Stockholm", CountryID = CountryGuid1},
            //        new City{CityName="Göteborg", CountryID = CountryGuid1},
            //        new City{CityName="Oslo", CountryID = CountryGuid2},
            //        new City{CityName="Halden", CountryID = CountryGuid2}

            //    };
            //    foreach (City c in cities)
            //    {
            //        context.Cities.Add(c);
            //    }
            //    context.SaveChanges();
        }
    }
}
