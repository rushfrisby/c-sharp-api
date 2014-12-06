using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Signifyd.RestClient
{
  /// <summary>
  /// Base client class 
  /// with some mild dependency injection and basic post/get methods
  /// All calls to the RestSharp library happen here.
  /// </summary>
  public abstract class ClientBase
  {

    /// <summary>
    /// API key for accessing the REST interface.
    /// Get one online with your developer account.
    /// </summary>
    private readonly string _apiKey = null;

    /// <summary>
    /// default constructor reads API key from config settings.
    /// </summary>
    protected ClientBase() : this(Api.ApiKeyFromConfig)
    {
    }
    
    /// <summary>
    /// optional API key can be passed in
    /// </summary>
    /// <param name="apiKey"></param>
    protected ClientBase(string apiKey)
    {
      _apiKey = apiKey;
    }

    /// <summary>
    /// All downstream clients require basic auth defined once here  
    /// </summary>
    /// <returns>RestClient</returns>
    protected RestSharp.RestClient RestClientWithBasicAuth()
    {

      // create a RestSharp client
      // include the base AUI and some basic auth
      var client = new RestSharp.RestClient()
      {
        BaseUrl = new Uri(Api.BaseUri),
        Authenticator = new HttpBasicAuthenticator(_apiKey, "")
      };
      return client;
    }

    /// <summary>
    /// format a request for a particular path
    /// </summary>
    /// <param name="path"></param>
    /// <returns>RestRequest</returns>
    protected RestSharp.RestRequest RestRequestGet(string path)
    {
      
      // create a RestSharp request with json formatting
      var request = new RestRequest(path, Method.GET)
      {
        RequestFormat = DataFormat.Json
      };
      return request;
    }


    /// <summary>
    /// format a request without a path.
    /// </summary>
    /// <returns>RestRequest</returns>
    protected RestSharp.RestRequest RestRequestGet()
    {
      var request = new RestRequest(Method.GET)
      {
        RequestFormat = DataFormat.Json
      };
      return request;
    }

    /// <summary>
    /// format a post request with a path
    /// </summary>
    /// <param name="path"></param>
    /// <returns>RestRequest</returns>
    protected RestSharp.RestRequest RestRequestPost(string path)
    {
      var request = new RestRequest(path,Method.POST)
      {
        RequestFormat = DataFormat.Json,
      };
      return request;
    }


    /// <summary>
    /// format a post request without a path
    /// </summary>
    /// <returns>RestRequest</returns>
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
