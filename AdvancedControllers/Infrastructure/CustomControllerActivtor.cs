using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using AdvancedControllers.Controllers;

namespace AdvancedControllers.Infrastructure
{
    public class CustomControllerActivtor : IControllerActivator
    {
        public IController Create(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == typeof(ProductController))
            {
                controllerType = typeof(CustomerController);
            }

            IController res = DependencyResolver.Current.GetService(controllerType) as IController;

            return res;
        }
    }
}