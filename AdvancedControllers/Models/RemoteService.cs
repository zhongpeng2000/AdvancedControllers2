using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;

namespace AdvancedControllers.Models
{
    public class RemoteService
    {
        public string GetRemoteData()
        {
            Thread.Sleep(2000);
            return "Hello from the other side of the world";
        }
    }
}