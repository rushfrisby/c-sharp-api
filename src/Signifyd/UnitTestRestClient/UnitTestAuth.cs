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
      using (var client = new SignifydRestClient())
      {
        var result = client.AuthClient.Authenticate();
        Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
      }
    }
  }
}
