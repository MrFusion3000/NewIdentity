//using Identity.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Identity.Migrations
//{
//    public class Configuration
//    {
//        protected void Seed(Identity.Models.AppIdentityDbContext context)
//        {
//            //  This method will be called after migrating to the latest version.
//            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
//            //  to avoid creating duplicate seed data.
//            context.Countries.Add(new Country { ID = 1, CountryName = "Sweden" }
//            context.Countries.Add (new Country { ID = 2, CountryName = "Norway" }
//            );

//            context.Cities.AddOrUpdate(x => x.ID,
//                new City { Id = 1, CountryId = 1, CityName = "Stockholm" },
//                new City { Id = 2, CountryId = 1, CityName = "Gothenburg" },
//                new City { Id = 3, CountryId = 1, CityName = "Norrköping" },
//                new City { Id = 4, CountryId = 2, CityName = "Oslo" },
//                new City { Id = 5, CountryId = 2, CityName = "Bergen" },
//                new City { Id = 6, CountryId = 1, CityName = "Tanumshede" },
//                new City { Id = 7, CountryId = 2, CityName = "Halden" }
//            );
//        }
//    }
//}
