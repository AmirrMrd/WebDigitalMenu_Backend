using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Caching;
using System.Text.Json;
using System.Web;
using System.Web.Caching;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Web_MenuDigital.Models;
using Web_MenuDigital.Repository;
using Web_MenuDigital.Services;

namespace Web_MenuDigital
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

            /// => Update repository branch list
            //StreamReader reader = new StreamReader(file);
            //var des_data = JsonSerializer.Deserialize<List<Branch>>(reader.ReadToEnd());
            //LookUp lookUp = new LookUp();
            //lookUp.BranchesList = des_data;
            //reader.Close();
        }
    }
}
