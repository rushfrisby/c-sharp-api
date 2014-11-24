using System;
using System.Diagnostics;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Signifyd.RestClient;

namespace UnitTestRestClient
{
  [TestClass]
  public class UnitTestAuth
  {
    private string _apiKey = "SFoNFEYtDTR1dyEgB5WssxCIp";

    [TestMethod]
    public void Authenticate()
    {
      var result = Auth.Authenticate(_apiKey);
      Assert.AreEqual(result.StatusCode,HttpStatusCode.OK);
    }
  }
}
