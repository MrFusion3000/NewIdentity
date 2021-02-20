using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<CountryCity> CountryCities { get; set; }


        //        public virtual City Cities { get; set; }

        //public enum Country
        //{
        //    USA, UK, France, Germany, Russia
        //}
    }
}
