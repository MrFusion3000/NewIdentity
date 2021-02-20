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
            context.Database.EnsureCreated();

            //if (context.Users.Any())
            //{ }

            //var users = new User[]
            //{
            //    new User{Name="Arne", Email="arne@mail.com", CityId=1, CountryID=1, Password="Admin1234!"}
            //};
            //foreach (User u in users)
            //{
            //    context.Users.Add(u);
            //}

            // Look for any Countries
            if (context.Countries.Any())
            {
                return;   // DB has been seeded
            }

            // Add sample countries
            var countries = new Country[]
            {
            new Country{CountryName="Sweden"},
            new Country{CountryName="Norway"},

            };
            foreach (Country s in countries)
            {
                context.Countries.Add(s);
            }
            context.SaveChanges();

            // Add sample Cities
            var cities = new City[]
            {
                new City{CityId=1,CityName="Stockholm"},
                new City{CityId=2,CityName="Göteborg"},
                new City{CityId=3,CityName="Oslo"},
                new City{CityId=4,CityName="Halden"}
            };
            foreach (City c in cities)
            {
                context.Cities.Add(c);
            }
            context.SaveChanges();

            // Add connection Country -- City 
            var countryCity = new CountryCity[]
            {
            new CountryCity{CountryID=1,CityID=1},
            new CountryCity{CountryID=1,CityID=2},
            new CountryCity{CountryID=2,CityID=3},

            };
            foreach (CountryCity e in countryCity)
            {
                context.CountryCities.Add(e);
            }
            context.SaveChanges();
        }
    }
}
