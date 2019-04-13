using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace WEB.AppStart {
    public partial class Startup {
        private void ConfigureOrderRoute(IRouteBuilder context) { 
            context.MapAreaRoute(
                "default_orders", 
                "orders",
                "orders/{controller}/{action}/{id?}"
            );
        }
    }
}