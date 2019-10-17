using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace WEB.AppStart {
    
    public partial class Startup {
        private void ConfigureDashboardRoute(IRouteBuilder context) { 
            context.MapAreaRoute(
                "default_providers", 
                "DashBoard",
                "DashBoard/{controller}/{action}/{id?}"
            );
        }
    }
}