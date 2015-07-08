using System;
using System.Linq;
using System.ServiceModel.Activation;
using System.Web;
using System.Web.Routing;
using Ifx.ServiceModelEx.Hosting;
using Swaggerator;

namespace Rk.Manager
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            
            var list = IISFactory.FindServices();
            foreach (var type in list.Distinct())
            {
                var factory = new IISFactory();
                RouteTable.Routes.Add(new ServiceRoute(type.FullName + ".svc", factory, type));
                RouteTable.Routes.Add(new ServiceRoute(type.Name, factory, type));
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

        protected void Application_PreSendRequestHeaders(object sender, EventArgs e)
        {
            var app = sender as HttpApplication;
            if (app == null || !app.Request.IsLocal || app.Context == null)
                return;
            var headers = app.Context.Response.Headers;
            headers.Remove("Server");
            headers.Remove("x-sourcefiles");
        }
    }
}