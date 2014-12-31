using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.Model
{
  public class ResponseAttributeOrganization : ResponseAttribute
  {
    public ResponseDetailOrganization Details { get; set; }
  }
}
