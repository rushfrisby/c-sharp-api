using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Signifyd.RestClient
{
  public class ClientBase
  {

    private string _apiKey = null;

    public ClientBase()
    {
      _apiKey = Api.ApiKeyFromConfig;
    }

    public ClientBase(string apiKey)
    {
      _apiKey = apiKey;
    }

    protected RestSharp.RestClient RestClientWithBasicAuth()
    {

      // var client = new RestSharp.RestClient
    //  {
    //    BaseUrl = Api.BaseUri,
    //    Authenticator = new HttpBasicAuthenticator(apiKey, "")
    //  };
      var client = new RestSharp.RestClient()
      {
        BaseUrl = new Uri(Api.BaseUri),
        Authenticator = new HttpBasicAuthenticator(_apiKey, "")
      };
      return client;
    }

    protected RestSharp.RestRequest RestRequestGet(string path)
    {
      var request = new RestRequest(path, Method.GET)
      {
        RequestFormat = DataFormat.Json
      };
      return request;
    }

    protected RestSharp.RestRequest RestRequestGet()
    {
      var request = new RestRequest(Method.GET)
      {
        RequestFormat = DataFormat.Json
      };
      return request;
    }

    protected RestSharp.RestRequest RestRequestPost(string path)
    {
      var request = new RestRequest(path,Method.POST)
      {
        RequestFormat = DataFormat.Json,
      };
      return request;
    }

    protected RestSharp.RestRequest RestRequestPost()
    {
      var request = new RestRequest(Method.POST)
      {
        RequestFormat = DataFormat.Json,
      };
      return request;
    }

  }
}
