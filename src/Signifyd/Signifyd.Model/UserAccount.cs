using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.Model
{
    public class Address
    {
      public string StreetAddress { get; set; }
      public string Unit { get; set; }
      public string City { get; set; }
      public string ProvinceCode { get; set; }
      public string PostalCode { get; set; }
      public string CountryCode { get; set; }
      public string Latitude { get; set; }
      public string Longitude { get; set; }

    }
}
