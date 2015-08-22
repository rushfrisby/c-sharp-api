using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.RestClient
{

  /// <summary>
  /// Simple setting class to hold all the magic strings specific to
  /// this particular API.
  /// </summary>
  public static class Api
  {
    /// <summary>
    /// The base URI for all API calls.  
    /// If the API changes versions this is the place to configure.
    /// </summary>
    public const string BaseUri = "https://api.signifyd.com/v2/";

    /// <summary>
    /// The REST API uses a noun-only URI design (this is a good thing)
    /// this client library uses Actions that closely follow the docs
    /// Here we are mapping noun+verb actions to URI nouns.
    /// </summary>
    public static class Action
    {
      /// <summary>
      /// There is no specific Auth noun so we overload cases
      /// </summary>
      public const string Auth = "cases";

      /// <summary>
      /// adding a case to cases
      /// </summary>
      public const string CaseAdd = "cases";

      /// <summary>
      /// Getting a case by ID
      /// </summary>
      public const string CaseGet = "case/{id}";
    }

    /// <summary>
    /// parameters used by the API defined as strings
    /// </summary>
    public static class Parms
    {
      /// <summary>
      /// this can be a case ID or an order ID
      /// the rest API does not differentiate
      /// </summary>
      public const string Id = "id";
    }

    /// <summary>
    /// A standard configuration settings file is a good place to store your API key.
    /// If you would like to perform extra security measures this would be a good place to do so.
    /// </summary>
    public static string ApiKeyFromConfig {

      get
      {
        return ConfigurationManager.AppSettings["ApiKey"];
      }
    }

  }
}
