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
    public const string BaseUri = "https://api.signifyd.com/v2/";
    public const string Auth = "cases";
    public const string CaseAdd = "cases";
    public const string CaseGet = "case/{id}";

    public class Parms
    {
      public const string Id = "id";
    }

    public static string ApiKeyFromConfig {
      get
      {
        return ConfigurationManager.AppSettings["ApiKey"];
      }
    }

  }
}
