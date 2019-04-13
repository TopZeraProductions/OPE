using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace WEB.AppStart {

    public partial class Startup {
        // metodo de Configuracao de rotas 
        private void ConfigureRoute(IRouteBuilder route) {
            route.MapAreaRoute(
                "default_area", 
                "area",
                "{area:exists}/{controller=Start}/{action=Home}/{id?}"
            );
            
            route.MapRoute(
                "default", 
                "{controller=Start}/{action=Index}/{id?}"
            );
            
            ConfigureProductRoute(route);
            ConfigureStartRoute(route);
            ConfigureErrorsRoute(route);
            ConfigureOrderRoute(route);
        }
    }
}