using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdvancedControllers.Models;
using AdvancedControllers.Infrastructure;

namespace AdvancedControllers.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Result", new Result { ControllerName = "Home", ActionName = "Index" });
        }



        [Local]
        [ActionName("Index")]
        public ViewResult LocalIndex()
        {
            return View("Result", new Result { ControllerName = "Home", ActionName = "LocalIndex" });
        }

        protected override void HandleUnknownAction(string actionName)
        {
            Response.Write(string.Format("You requested the {0} action", actionName));
        }
    }
}