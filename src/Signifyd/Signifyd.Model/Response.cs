using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.Model
{
    public class Response
    {
      public int CaseId { get; set; }
      public string Uuid { get; set; }
      public string OrderId { get; set; }
      public DateTime OrderDate { get; set; }
      public Status Status { get; set; }
      public DateTime CreatedAt { get; set; }
      public DateTime UpdatedAt { get; set; }
      public double Score { get; set; }
      public string Headline { get; set; }
      public ReviewDisposition ReviewDisposition { get; set; }
    }
}
