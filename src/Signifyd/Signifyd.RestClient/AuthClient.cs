using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Signifyd.RestClient
{

  //Example Request
  //  $ curl https://api.signifyd.com/v2/cases \
  //  -u <key>:

  /// <summary>
  /// A simple auth client to verify configuration settings
  /// </summary>
  public class AuthClient : ClientBase
  {

    /// <summary>
    /// default constructor needs no parameters
    /// </summary>
    public AuthClient()
      : base()
    {
    }


    /// <summary>
    /// optional constructor accepts API key
    /// </summary>
    /// <param name="apiKey"></param>
    public AuthClient(string apiKey)
      : base(apiKey)
    {
    }

    /// <summary>
    /// Authenticate action
    /// A Simple way to test the validity of your API key.
    /// </summary>
    /// <returns>IRestResponse</returns>
    public IRestResponse Authenticate()
    {
      // grab a basic auth client
      var client = RestClientWithBasicAuth();

      // create the auth action request
      var request = RestRequestGet(Api.Action.Auth);

      // perform the action and return the result
      var result = client.Execute(request);

      return result;
    }

    /// <summary>
    /// Authenticate action
    /// An Async way to test the validity of your API key.
    /// call using var result = await AuthenticateAsync()
    /// </summary>
    /// <returns>IRestResponse</returns>
    public Task<IRestResponse> AuthenticateAsync()
    {
      // setup a completion task with a rest response
      var tcs = new TaskCompletionSource<IRestResponse>();

      // grab a basic auth client
      var client = RestClientWithBasicAuth();

      // create the auth action request
      var request = RestRequestGet(Api.Action.Auth);

      // perform the action and set the result 
      var result = client.ExecuteAsync(request, tcs.SetResult);
      
      // return the task that be be queried later for the result.
      return tcs.Task;
    }

  }
}
