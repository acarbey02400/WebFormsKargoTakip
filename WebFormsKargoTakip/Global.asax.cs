using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using WebFormsKargoTakip.DataAccess.Repositories;
using WebFormsKargoTakip.DependencyInjection;

namespace WebFormsKargoTakip
{
    public class Global : HttpApplication
    {
       protected void Application_Start(object sender, EventArgs e)
        {
            // Uygulama başlangıcında çalışan kod
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<IUserRepository, UserRepository>();
            WebFormsKargoTakip.DependencyInjection.ServiceProvider provider = 
                new WebFormsKargoTakip.DependencyInjection.ServiceProvider(services.BuildServiceProvider());
            HttpRuntime.WebObjectActivator = provider;
        }
    }
}