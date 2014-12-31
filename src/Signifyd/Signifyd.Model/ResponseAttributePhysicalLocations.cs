using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.Model
{
  public class ResponseAttributePhysicalLocation : ResponseAttribute
  {
    public ResponseDetailPhysicalLocation Details { get; set; }
  }
}
