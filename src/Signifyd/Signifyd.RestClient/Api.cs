using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.RestClient
{
  public class Api
  {
    public static readonly Uri BaseUri = new Uri("https://api.signifyd.com/v2/cases");
    public static string ApiKey {
      get
      {
        return ConfigurationManager.AppSettings["ApiKey"];
      }
    }

  }
}
