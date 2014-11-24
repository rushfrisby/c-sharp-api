using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Signifyd.RestClient
{

  //Example Request
  //  $ curl https://api.signifyd.com/v2/cases \
  //  -u <key>:

    public class Auth
    {
      public static IRestResponse Authenticate(string apiKey)
      {
        var client = new RestSharp.RestClient
        {
          BaseUrl = Api.BaseUri,
          Authenticator = new HttpBasicAuthenticator(apiKey, "")
        };

        var request = new RestRequest
        {
          Method = Method.GET,
          RequestFormat = DataFormat.Json
        };
        var result = client.Execute(request);

        return result;
      }
    }
}
