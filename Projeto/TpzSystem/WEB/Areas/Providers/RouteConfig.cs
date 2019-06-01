using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace WEB.AppStart {
    
    public partial class Startup {
        private void ConfigureProvidersRoute(IRouteBuilder context) { 
            context.MapAreaRoute(
                "default_providers", 
                "providers",
                "providers/{controller}/{action}/{id?}"
            );
        }
    }
}