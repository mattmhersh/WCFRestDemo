using System;
using System.Linq;
using System.ServiceModel.Activation;
using System.Web.Routing;
using Ifx.ServiceModelEx.Hosting;
using Swaggerator;

namespace Rk.Manager
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var list = IISFactory.FindServices();
            foreach (var type in list.Distinct())
            {
                var factory = new IISFactory();
                RouteTable.Routes.Add(new ServiceRoute(type.FullName + ".svc", factory, type));
                RouteTable.Routes.Add(new ServiceRoute("v1/" + type.Name, factory, type));
            }
            RouteTable.Routes.Add(new ServiceRoute("api-docs", new WebServiceHostFactory(), typeof(Discoverator)));            
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}