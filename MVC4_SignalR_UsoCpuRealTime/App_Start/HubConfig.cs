using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC4_SignalR_UsoCpuRealTime
{
    public class HubConfig
    {
        public static void RegisterHubRoutes()
        {
            RouteTable.Routes.MapHubs();
        }
    }
}