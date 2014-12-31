using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Signifyd.Model;
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
        var json = result.Content;

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

    private Purchase GetPurchaseData()
    {
      var purchase = new Purchase() {
        BrowserIpAddress = Util.LocalIP(),
        OrderId = Guid.NewGuid().ToString(),
        CreatedAt = DateTime.UtcNow.ToString("o"),
        PaymentGateway = "stripe",
        Currency = "USD",
        AvsResponseCode = "Y",
        CvvResponseCode = "M",
        TotalPrice = 74.99,
        Shipments = new List<Shipment>() {
            new Shipment(){	
               TrackingNumber= "ABCDTEST1234",        		
               ShippingMethod= "ground",
               Shipper= "UPS",
               ShippingPrice= 5.25
            }
        },
        Products = new List<Product>()
        {
          new Product()
          {
              ItemId= "1",
              ItemName= "Sparkly sandals",
              ItemUrl= "http://mydomain.com/sparkly-sandals",
              ItemImage= "http://mydomain.com/images/sparkly-sandals.jpeg",
              ItemQuantity= 1,
              ItemPrice= 49.99,
              ItemWeight= 5
          },
          new Product()
          {
              ItemId= "2",
              ItemName= "Sparkly sandals",
              ItemUrl= "http://mydomain.com/sparkly-sandals",
              ItemImage= "http://mydomain.com/images/sparkly-sandals.jpeg",
              ItemQuantity= 1,
              ItemPrice= 49.99,
              ItemWeight= 5
          }
        },
        Recipients = new List<Recipient>()
        {
          new Recipient(){
            FullName= "Will Smith",
            ConfirmationEmail= "will@gmail.com",
            ConfirmationPhone= "111111111",
            DeliveryAddress = new Address(){
                StreetAddress= "123 ABS",
                Unit= "4A",
                City= "LA",
                ProvinceCode= "CA",
                PostalCode= "60621",
                CountryCode= "US",
                Latitude= "11.11",
                Longitude= "-44.44"
            }
            },
            new  Recipient(){
            FullName= "George Smith",
            ConfirmationEmail= "George@gmail.com",
            ConfirmationPhone= "2222222",
            DeliveryAddress = new Address() {
                StreetAddress= "345",
                Unit= "1A",
                City= "NYC",
                ProvinceCode= "NY",
                PostalCode= "20121",
                CountryCode= "US",
                Latitude= "71.11",
                Longitude= "-33.44"
            }
          }
        },
        Card = new Card()
        {
          CardHolderName = "Robert Smith",
          Bin = 407441,
          Last4 = "1234",
          ExpiryMonth = 12,
          ExpiryYear = 2015,
          Hash = "sdfvbkel456hj",
          BillingAddress = new Address()
          {
            StreetAddress = (string)null,
            Unit = "2A",
            City = "Chicago",
            ProvinceCode = "IL",
            PostalCode = "60622",
            CountryCode = "US",
            Latitude = "41.92",
            Longitude = "-87.65"
          }
        },
        UserAccount = new UserAccount()
        {
          EmailAddress = "bob@gmail.com",
          Username = "bobbo",
          Phone = "5555551212",
          CreatedDate = "2013-01-18T17:54:31-05:00",
          AccountNumber = "54321",
          LastOrderId = "4321",
          AggregateOrderCount = 40,
          AggregateOrderDollars = 5000,
          LastUpdateDate = "2013-01-18T17:54:31-05:00"
        },
        Seller = new Seller()
        {
          Name = "Amazon",
          Domain = "amazon.com",
          ShipFromAddress = new Address()
          {
            StreetAddress = "1850 Mercer Rd",
            Unit = (string)null,
            City = "Lexington",
            ProvinceCode = "KY",
            PostalCode = "40511",
            CountryCode = "US",
            Latitude = "38.07",
            Longitude = "-84.53"
          },
          CorporateAddress = new Address()
          {
            StreetAddress = "410 Terry Ave",
            Unit = "3L",
            City = "Seattle",
            ProvinceCode = "WA",
            PostalCode = "98109",
            CountryCode = "US",
            Latitude = "47.6",
            Longitude = "-122.33"
          }
        }
      };
      return purchase;
    }

    private dynamic GetPurchaseDataDynamic()
    {
      var purchase = new
      {
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
