using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.Model
{
    public class Purchase
    {
      public string BrowserIpAddress { get; set; }
      public string OrderId { get; set; }
      public string CreatedAt { get; set; }
      public string PaymentGateway { get; set; }
      public string Currency { get; set; }
      public string AvsResponseCode { get; set; }
      public string CvvResponseCode { get; set; }
      public string OrderChannel { get; set; }
      public string ReceivedBy { get; set; }
      public double TotalPrice { get; set; }
      public List<Product> Products { get; set; }
      public List<Shipment> Shipments { get; set; }
      public List<Recipient> Recipients { get; set; }
      public Card Card { get; set; }
      public UserAccount UserAccount { get; set; }
      public Seller Seller { get; set; }


    }
}
