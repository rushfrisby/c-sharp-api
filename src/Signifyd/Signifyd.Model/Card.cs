using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.Model
{
    public class Card
    {
      public string CardHolderName { get; set; }
      public int Bin { get; set; }
      public string Last4 { get; set; }
      public int ExpiryMonth { get; set; }
      public int ExpiryYear { get; set; }
      public string Hash { get; set; }
      public Address BillingAddress { get; set; }

    }
}
