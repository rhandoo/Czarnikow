using System.Web.Http;

namespace Czarnikow.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Ioc.RegisterTypes();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        //AreaRegistration.RegisterAllAreas();
        //GlobalConfiguration.Configure(WebApiConfig.Register);
        //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        //RouteConfig.RegisterRoutes(RouteTable.Routes);
        //BundleConfig.RegisterBundles(BundleTable.Bundles);

    }
}
