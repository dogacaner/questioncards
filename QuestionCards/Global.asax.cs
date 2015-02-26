using Autofac;
using Autofac.Integration.Mvc;
using QuestionCards.PersistenceEF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace QuestionCards
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //var builder = new ContainerBuilder();
            
            //builder.RegisterDbContext<QuestionCardsContext>("DefaultConnection", Assembly.Load("QuestionCards.Domain"));
            ////builder.RegisterDbContext<KalsiyumContext>("DefaultConnection", Assembly.Load("Kalsiyum.Domain"),
            ////   Assembly.Load("Kalsiyum.CampaignEngine"));
            //var container = builder.Build();
            
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

    }
}
