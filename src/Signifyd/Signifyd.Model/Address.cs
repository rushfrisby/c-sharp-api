using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.Model
{
    public class UserAccount
    {
      public string EmailAddress { get; set; }
      public string Username { get; set; }
      public string Phone { get; set; }
      public string CreatedDate { get; set; }
      public string AccountNumber { get; set; }
      public string LastOrderId { get; set; }
      public int AggregateOrderCount { get; set; }
      public double AggregateOrderDollars { get; set; }
      public string LastUpdateDate { get; set; }

    }


}
