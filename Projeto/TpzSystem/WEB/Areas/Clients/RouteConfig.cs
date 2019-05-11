using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace WEB.AppStart {
    
    public partial class Startup {
        private void ConfigureClientsRoute(IRouteBuilder context) { 
            context.MapAreaRoute(
                "default_clients", 
                "clients",
                "clients/{controller}/{action}/{id?}"
            );
        }
    }
}