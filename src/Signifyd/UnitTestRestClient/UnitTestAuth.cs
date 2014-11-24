using System;
using System.Configuration;
using System.Diagnostics;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Signifyd.RestClient;

namespace UnitTestRestClient
{
  [TestClass]
  public class UnitTestAuth
  {
   
    [TestMethod]
    public void Authenticate()
    {
      var apiKey = Api.ApiKey;
      var result = Auth.Authenticate(apiKey);
      Assert.AreEqual(result.StatusCode,HttpStatusCode.OK);
    }
  }
}
