using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

using WEB.AppInfra.Cookies.Interface;
using WEB.AppInfra.Cookies.Service;

namespace WEB.AppStart {

    public partial class Startup {
        public void ConfigureServices(IServiceCollection Services) {
            Services.Configure<CookiePolicyOptions>(
                options => {
                    options.CheckConsentNeeded    = context => true;
                    options.MinimumSameSitePolicy = SameSiteMode.None;
                }
            );

            Services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            Services.AddHttpContextAccessor(); // injeta o contexto http fora das controllers
            
            Services.AddTransient<ICookieServices, CookieServices>();
        }
    }

}