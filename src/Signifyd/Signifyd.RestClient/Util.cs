﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Signifyd.RestClient
{
  public class Util
  {
    public static string LocalIP()
    {
      IPHostEntry host;
      string localIP = "?";
      host = Dns.GetHostEntry(Dns.GetHostName());
      foreach (IPAddress ip in host.AddressList) {
        if (ip.AddressFamily == AddressFamily.InterNetwork){
          localIP = ip.ToString();
        }
      }
      return localIP;
    }

  

  }
}
