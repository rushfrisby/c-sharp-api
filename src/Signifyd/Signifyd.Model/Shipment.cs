using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.Model
{
    public class Shipment
    {
      public string Shipper { get; set; }
      public string ShippingMethod { get; set; }
      public string ShippingPrice { get; set; }
      public string TrackingNumber { get; set; }

    }
}
