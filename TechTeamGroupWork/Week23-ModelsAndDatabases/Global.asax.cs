using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using System.Data.Entity;
using FilmReview.Models;

namespace FilmReview
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
#if true
            Database.SetInitializer(new MovieDataInitialiser());
#endif
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
