using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace WEB.AppStart {
    
    public partial class Startup {
        private void ConfigureErrorsRoute(IRouteBuilder context) { 
            context.MapAreaRoute(
                "default_errors", 
                "Errors",
                "Errors/{controller}/{action}/{id?}"
            );
        }
    }
}