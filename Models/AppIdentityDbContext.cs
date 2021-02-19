using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity.Models
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options) { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{

        //    string ADMIN_ID = "02174cf0–9412–4cfe - afbf - 59f706d72cf6";
        //    string ROLE_ID = "341743f0 - asd2–42de - afbf - 59kmkkmk72cf6";

        //    //seed admin role
        //    builder.Entity<IdentityRole>().HasData(new IdentityRole
        //    {
        //        Name = "SuperAdmin",
        //        NormalizedName = "SuperAdmin",
        //        Id = ROLE_ID,
        //        ConcurrencyStamp = ROLE_ID
        //    });

        //    //create user
        //    var appUser = new AppUser
        //    {
        //        Id = ADMIN_ID,
        //        Email = "nico@gmail.com",
        //        EmailConfirmed = true,
        //        CountryId = 1,
        //        CityId = 1,
        //        UserName = "nico" 
        //   };

        //    //set user password
        //    PasswordHasher<AppUser> ph = new PasswordHasher<AppUser>();
        //    appUser.PasswordHash = ph.HashPassword(appUser, "mypassword_ ?");

        //    //seed user
        //    builder.Entity<AppUser>().HasData(appUser);

        //    //set user role to admin
        //    builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        //    {
        //        RoleId = ROLE_ID,
        //        UserId = ADMIN_ID
        //    });
        //}
    }

}
