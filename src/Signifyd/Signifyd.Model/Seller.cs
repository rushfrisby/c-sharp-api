using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.Model
{
    public class Seller
    {
      public string Name { get; set; }
      public string Domain { get; set; }
      public Address ShipFromAddress { get; set; }
      public Address CorporateAddress { get; set; }

    }
}
