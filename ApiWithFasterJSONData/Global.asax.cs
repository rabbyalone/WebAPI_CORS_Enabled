using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Thinktecture.IdentityModel.Http.Cors.WebApi;

namespace ApiWithFasterJSONData
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Register cors class
            CorsConfig.RegisterCors(GlobalConfiguration.Configuration);

        }

    }

    //Class for CORS handling
    public class CorsConfig
    {
        public static void RegisterCors(HttpConfiguration httpConfig)
        {
            WebApiCorsConfiguration corsConfig = new WebApiCorsConfiguration();
            corsConfig.RegisterGlobal(httpConfig);
            corsConfig.ForAllResources().AllowAllOriginsAllMethodsAndAllRequestHeaders();
        }
    }
    
}
