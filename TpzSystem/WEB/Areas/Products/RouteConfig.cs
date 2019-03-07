using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace WEB.AppStart {
    public partial class Startup {
        private void ConfigureProductRoute(IRouteBuilder context) { 
            context.MapAreaRoute(
                "default_products", 
                "products",
                "products/{controller}/{action}/{id?}"
            );
        }
    }
}