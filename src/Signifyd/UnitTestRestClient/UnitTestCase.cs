using System;
using System.Diagnostics;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Signifyd.RestClient;

namespace UnitTestRestClient
{
  [TestClass]
  public class UnitTestCase
  {

    private string _caseId;

    [TestMethod]
    public void CaseAdd()
    {
      var purchase = GetPurchaseData();
      using (var client = new SignifydRestClient())
      {
        var result = client.CaseClient.Add(purchase);
        var json = result.content;

        Assert.AreEqual(result.StatusCode, HttpStatusCode.Created);
      }
    }

    [TestMethod]
    public void CaseGetByCaseId()
    {
      using (var client = new SignifydRestClient()) {
        var result = client.CaseClient.GetByCaseId(_caseId);
        Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
      }
    }

    private dynamic GetPurchaseData()
    {
      var purchase = new {
        browserIpAddress = Util.LocalIP(),
        orderId = Guid.NewGuid().ToString(),
        createdAt = DateTime.UtcNow.ToString("o"),
        paymentGateway = "stripe",
        currency = "USD",
        avsResponseCode = "Y",
        cvvResponseCode = "M",
        totalPrice = 74.99,
        shipments = new[] {
            new {	
               trackingNumber= "ABCDTEST1234",        		
               shippingMethod= "ground",
               shipper= "UPS",
               shippingPrice= 5.25
            }
        },
        products = new[]
        {
          new
          {
              itemId= "1",
              itemName= "Sparkly sandals",
              itemUrl= "http://mydomain.com/sparkly-sandals",
              itemImage= "http://mydomain.com/images/sparkly-sandals.jpeg",
              itemQuantity= 1,
              itemPrice= 49.99,
              itemWeight= 5
          },
          new
          {
              itemId= "2",
              itemName= "Sparkly sandals",
              itemUrl= "http://mydomain.com/sparkly-sandals",
              itemImage= "http://mydomain.com/images/sparkly-sandals.jpeg",
              itemQuantity= 1,
              itemPrice= 49.99,
              itemWeight= 5
          }
        },
        recipients = new[] 
        {
          new {
            fullName= "Will Smith",
            confirmationEmail= "will@gmail.com",
            confirmationPhone= "111111111",
            deliveryAddress = new {
                streetAddress= "123 ABS",
                unit= "4A",
                city= "LA",
                provinceCode= "CA",
                postalCode= "60621",
                countryCode= "US",
                latitude= 11.11,
                longitude= -44.44
            }
            },
            new {
            fullName= "George Smith",
            confirmationEmail= "George@gmail.com",
            confirmationPhone= "2222222",
            deliveryAddress = new {
                streetAddress= "345",
                unit= "1A",
                city= "NYC",
                provinceCode= "NY",
                postalCode= "20121",
                countryCode= "US",
                latitude= 71.11,
                longitude= -33.44
            }
          }
        },
        card = new
        {
          cardHolderName = "Robert Smith",
          bin = 407441,
          last4 = 1234,
          expiryMonth = 12,
          expiryYear = 2015,
          hash = "sdfvbkel456hj",
          billingAddress = new
          {
            streetAddress = (string)null,
            unit = "2A",
            city = "Chicago",
            provinceCode = "IL",
            postalCode = "60622",
            countryCode = "US",
            latitude = 41.92,
            longitude = -87.65
          }
        },
        userAccount = new
        {
          email = "bob@gmail.com",
          username = "bobbo",
          phone = "5555551212",
          createdDate = "2013-01-18T17:54:31-05:00",
          accountNumber = "54321",
          lastOrderId = "4321",
          aggregateOrderCount = 40,
          aggregateOrderDollars = 5000,
          lastUpdateDate = "2013-01-18T17:54:31-05:00"
        },
        seller = new
        {
          name = "Amazon",
          domain = "amazon.com",
          shipFromAddress = new
          {
            streetAddress = "1850 Mercer Rd",
            unit = (string)null,
            city = "Lexington",
            provinceCode = "KY",
            postalCode = "40511",
            countryCode = "US",
            latitude = 38.07,
            longitude = -84.53
          },
          corporateAddress = new
          {
            streetAddress = "410 Terry Ave",
            unit = "3L",
            city = "Seattle",
            provinceCode = "WA",
            postalCode = "98109",
            countryCode = "US",
            latitude = 47.6,
            longitude = -122.33
          }
        }
      };
      return purchase;
    }
  }
}
