using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using Chipotle.ItemDetails;
using Chipotle.Pricing;

namespace Chipotle.Web
{
    public class DropCreateDatabaseIfModelChanges : DropCreateDatabaseIfModelChanges<ISeedItems>
    {
        protected override void Seed(ISeedItems context)
        {
            context.Seed(context);
            base.Seed(context);
        }
    }
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<ISeedItemsPrice>(new MyItenPricingInitializer());
            Database.SetInitializer<ISeedItems>(new DropCreateDatabaseIfModelChanges());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
