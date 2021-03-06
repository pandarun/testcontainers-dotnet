﻿using System.Net;
using System.Net.Sockets;

namespace Container.Test.Utility
{
    public static class FreePortHelper
    {
        public static int GetFreePort()
        {
            var l = new TcpListener(IPAddress.Loopback, 0);
            l.Start();

            var port = ((IPEndPoint) l.LocalEndpoint).Port;
            l.Stop();

            return port;
        }
    }
}