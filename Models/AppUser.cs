using Microsoft.AspNetCore.Identity;

namespace Identity.Models
{
    public class AppUser : IdentityUser
    {
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public int CityId { get; set; }        
        public virtual City City { get; set; }

        public string CountryName { get; internal set; }
        public string CityName { get; internal set; }

    }
}
