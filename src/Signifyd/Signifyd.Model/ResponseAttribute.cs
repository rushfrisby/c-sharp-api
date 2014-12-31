using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.Model
{
    public class ResponseAttribute
    {
      public string Uuid { get; set; }
      public string EntityName { get; set; }
      public string Role { get; set; }  //MED: is this an enum?
      public bool Seeder { get; set; }
      public string SeederUuid { get; set; }
      //public object details { get; set; }
    }
}
