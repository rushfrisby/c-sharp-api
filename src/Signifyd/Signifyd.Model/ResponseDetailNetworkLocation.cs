using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.Model
{
  public class ResponseDetailNetworkLocation
    {
    public string AnonymizerStatus { get; set; }
    public string IpAddress { get; set; }
    public string Asn { get; set; }
    public string ConnectionType { get; set; }
    public string IpRoutingType { get; set; }
    }
}
