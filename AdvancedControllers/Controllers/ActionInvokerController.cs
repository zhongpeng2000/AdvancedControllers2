using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdvancedControllers.Infrastructure;

namespace AdvancedControllers.Controllers
{
    public class ActionInvokerController : Controller
    {

        public ActionInvokerController()
        {
            this.ActionInvoker = new CustomActionInvoker();
        }
    }
}