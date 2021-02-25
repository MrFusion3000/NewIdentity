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
            context.Database.Migrate(); ;


            // Look for any Countries
            if (context.Countries.Any())
            {
                return;   // DB has been seeded
            }

            // Add sample countries
            var countries = new Country[]
            {
            new Country{CountryName="Sweden", CountryId=1},
            new Country{CountryName="Norway", CountryId=2}

            };
            foreach (Country s in countries)
            {
                context.Countries.Add(s);
            }
            context.SaveChanges();

            //Add sample Cities
            var cities = new City[]
            {
                new City{CityId=1, CityName="Stockholm", CountryCityID = 1},
                new City{CityId=2, CityName="Göteborg", CountryCityID = 1},
                new City{CityId=3, CityName="Oslo", CountryCityID = 2},
                new City{CityId=4, CityName="Halden", CountryCityID = 2}

            };
            foreach (City c in cities)
            {
                context.Cities.Add(c);
            }
            context.SaveChanges();

            // Add sample connections Country -- City 
            //var countryCity = new CountryCity[]
            //{
            //new CountryCity{CountryId=1,CityId=1},
            //new CountryCity{CountryId=1,CityId=2},
            //new CountryCity{CountryId=2,CityId=3},

            //};
            //foreach (CountryCity e in countryCity)
            //{
            //    context.CountryCities.Add(e);
            //}
            //context.SaveChanges();
        }
    }
}
