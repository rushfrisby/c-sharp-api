using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.Model
{
  public class ResponseDetailAccount
    {
    public string username { get; set; }
    public string emailAddress { get; set; }
    public string dateCreated { get; set; }
    public string accountType { get; set; } // MED: is this an enum?
    }
}
