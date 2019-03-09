using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace WEB.AppStart {

    public partial class Startup {
        private void ConfigureRoute(IRouteBuilder routeBuilder) {
            
            routeBuilder.MapAreaRoute(
                "default_area", 
                "area",
                "{area:exists}/{controller=Start}/{action=Home}/{id?}"
            );
            
            routeBuilder.MapRoute(
                "default", 
                "{controller=Start}/{action=Index}/{id?}"
            );
            
            ConfigureProductRoute(routeBuilder);
            ConfigureStartRoute(routeBuilder);
        }
    }
}