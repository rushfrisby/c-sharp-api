using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.Model
{
    public class Card
    {
      public string cardHolderName { get; set; }
      public int bin { get; set; }
      public string last4 { get; set; }
      public int expiryMonth { get; set; }
      public int expiryYear { get; set; }
      public string hash { get; set; }
      public Address billingAddress { get; set; }

    }
}
