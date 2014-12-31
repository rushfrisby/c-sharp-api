using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.Model
{
    public class Product
    {
      public string ItemId { get; set; }
      public string ItemName { get; set; }
      public string ItemUrl { get; set; }
      public string ItemImage { get; set; }
      public int ItemQuantity { get; set; }
      public double ItemPrice { get; set; }
      public int ItemWeight { get; set; }

    }
}
