using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.RestClient
{
  public class SignifydRestClient : ClientBase, IDisposable
  {
    private string _apiKey = null;
    private CaseClient _caseClient;
    private AuthClient _authClient;

    public CaseClient CaseClient {
      get { return _caseClient ?? (_caseClient = _apiKey != null ? new CaseClient(_apiKey) : new CaseClient()); }
    }
    public AuthClient AuthClient
    {
      get { return _authClient ?? (_authClient = _apiKey != null ? new AuthClient(_apiKey) : new AuthClient()); }
    }

    public SignifydRestClient()
      :base()
    {
    }

    public SignifydRestClient(string apiKey)
      : base(apiKey)
    {
    }

    public void Dispose()
    {
      _authClient = null;
      _caseClient = null;
    }
  }
}
