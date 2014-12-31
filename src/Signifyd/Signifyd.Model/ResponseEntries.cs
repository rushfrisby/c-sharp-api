using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.Model
{
  public class ResponseEntries
    {
      public List<ResponseAttributeAccount> Accounts { get; set; }
      public List<ResponseAttributeOrganization> Organizations { get; set; }
      public List<ResponseAttributePhone> Phones { get; set; }
      public List<ResponseAttributePerson> People { get; set; }
      public List<ResponseAttributeNetworkLocation> NetworkLocations { get; set; }
      public List<ResponseAttributePhysicalLocation> PhysicalLocations { get; set; }
  }
}
