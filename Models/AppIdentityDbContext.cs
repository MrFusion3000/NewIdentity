using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Identity.Models
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options) { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().ToTable("Countries");
            modelBuilder.Entity<City>().ToTable("Cities");
            modelBuilder.Entity<Country>()
                .HasIndex(u => u.Id)
                .IsUnique();
            modelBuilder.Entity<City>()
                .HasIndex(u => u.Id)
                .IsUnique();

            string ADMIN_ID = "02174cf0 - 9412 - 4cfe - afbf - 59f706d72cf6";
            string ROLE_ID =  "341743f0 - asd2 - 42de - afbf - 59kmkkmk72cf";
            //string CITY_ID =  "341a43f0asa242deaabf59kmdkmd74c3";
            var InitUserCityId = Guid.Parse("258d7621e0db4958a098c400c8c9e0a4");

            //seed admin role
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "SuperAdmin",
                NormalizedName = "SuperAdmin",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });

            //create user
            var appUser = new AppUser
            {
                Id = ADMIN_ID,
                Email = "nico@crepro.com",
                EmailConfirmed = true,
                NormalizedEmail = "nico@crepro.com",
                NormalizedUserName = "nico",
                CityId = InitUserCityId,
                UserName = "nico"
            };

            //set user password
            PasswordHasher<AppUser> ph = new PasswordHasher<AppUser>();
            appUser.PasswordHash = ph.HashPassword(appUser, "Admin1234!");

            //seed user
            modelBuilder.Entity<AppUser>().HasData(appUser);

            //set user role to admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });

            //set countries
            var CountryGuid0 = Guid.NewGuid();
            var CountryGuid1 = Guid.NewGuid();
            var CountryGuid2 = Guid.NewGuid();
            //set cities
            var CityGuid1 = Guid.NewGuid();
            var CityGuid2 = Guid.NewGuid();
            var CityGuid3 = Guid.NewGuid();
            var CityGuid4 = Guid.NewGuid();
            var CityGuid5 = Guid.NewGuid();

            modelBuilder.Entity<Country>().HasData(
                new Country { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), CountryName = "Select" },
                new Country { Id = CountryGuid1, CountryName = "Sweden" },
                new Country { Id = CountryGuid2, CountryName = "Norway" }
                );

            //set cities
            modelBuilder.Entity<City>().HasData(
                new City {Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), CityName = "Select", CountryID = Guid.Empty },
                new City {Id = CityGuid1, CityName = "Deje", CountryID = CountryGuid1 },
                new City {Id = CityGuid2, CityName = "Stockholm", CountryID = CountryGuid1 },
                new City {Id = CityGuid3, CityName = "Göteborg", CountryID = CountryGuid1 },
                new City {Id = CityGuid4, CityName = "Oslo", CountryID = CountryGuid2 },
                new City {Id = CityGuid5, CityName = "Halden", CountryID = CountryGuid2 }
                );

        }
    }

}
