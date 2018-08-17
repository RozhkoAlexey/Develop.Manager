namespace Develop.Manager
{
    using Develop.Manager.App_Start;
    using System;
    using System.Web.Mvc;
    using System.Web.Routing;

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Error(object sender, EventArgs e)
        {
            var exception = Server.GetLastError();
            Logger.Log.Error(exception);
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Logger.InitLogger();
        }
    }
}
