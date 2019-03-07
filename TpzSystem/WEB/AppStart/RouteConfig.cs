using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace WEB.AppStart {

    public partial class Startup {
        private void ConfigureRoute(IRouteBuilder routeBuilder) {
            
            routeBuilder.MapAreaRoute(
                "default_area", 
                "area",
                "{area}/{controller}/{action}/{id?}"
            );
            
            routeBuilder.MapRoute(
                "default", 
                "{controller=Home}/{action=Index}/{id?}"
            );
            
            ConfigureProductRoute(routeBuilder);
        }
    }
}