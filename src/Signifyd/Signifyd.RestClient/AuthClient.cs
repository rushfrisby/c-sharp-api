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

  public class AuthClient : ClientBase
  {

    public AuthClient()
      : base()
    {
    }

    public AuthClient(string apiKey)
      : base(apiKey)
    {
    }

    public IRestResponse Authenticate()
    {
      var client = RestClientWithBasicAuth();
      var request = RestRequestGet(Api.Auth);
      var result = client.Execute(request);

      return result;
    }

  }
}
