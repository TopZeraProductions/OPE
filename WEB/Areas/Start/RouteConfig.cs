using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace WEB.AppStart {
    
    public partial class Startup {
        private void ConfigureStartRoute(IRouteBuilder context) { 
            context.MapAreaRoute(
                "default_start", 
                "start",
                "start/{controller}/{action}/{id?}"
            );
        }
    }
}