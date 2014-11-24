using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace Signifyd.RestClient
{

    //Example Request
    //$ curl https://api.signifyd.com/v2/cases \
    //  -u JlkfkjOLIFDKJlaksgjjer09389cvn: \
    //  -d {POST BODY} \
    //  -H "Content-type: application/json"


    public class Case
    {
      public static IRestResponse Add(string apiKey, dynamic purchase)
      {
        var client = new RestSharp.RestClient
        {
          BaseUrl = Api.BaseUri,
          Authenticator = new HttpBasicAuthenticator(apiKey, "")
        };

        var request = new RestRequest
        {
          Method = Method.POST,
          RequestFormat = DataFormat.Json,
        };

        request.AddJsonBody(purchase);

        var result = client.Execute(request);

        return result;
      }
    }
}
