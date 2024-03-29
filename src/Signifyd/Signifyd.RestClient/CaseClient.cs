﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using Signifyd.Model;

namespace Signifyd.RestClient
{

  public class CaseClient : ClientBase
  {

    public CaseClient()
      : base()
    {
    }

    public CaseClient(string apiKey)
      : base(apiKey)
    {
    }

    public IRestResponse Add(Purchase purchase)
    {
      var client = RestClientWithBasicAuth();
      var request = RestRequestPost(Api.Action.CaseAdd);
      request.AddJsonBody(purchase);
      var result = client.Execute(request);

      return result;
    }

    public IRestResponse GetByCaseId(string caseId)
    {
      var client = RestClientWithBasicAuth();
      var request = RestRequestGet(Api.Action.CaseGet);
      request.AddUrlSegment(Api.Parms.Id, caseId);
      var result = client.Execute(request);

      return result;
    }
  }
}
