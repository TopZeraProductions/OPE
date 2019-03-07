using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WEB.AppStart {

    public partial class Startup {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration _Configuration) {
            Configuration = _Configuration;
        }

        public void ConfigureServices(IServiceCollection Services) {
            Services.Configure<CookiePolicyOptions>(
                options => {
                    options.CheckConsentNeeded    = context => true;
                    options.MinimumSameSitePolicy = SameSiteMode.None;
                }
            );

            Services.AddMvc()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder App,
                              IHostingEnvironment Env) {

            if (Env.IsDevelopment()) {
                App.UseDeveloperExceptionPage();
            } else {
                App.UseExceptionHandler("/Home/Error");
                App.UseHsts();
            }

            App.UseHttpsRedirection();
            App.UseStaticFiles();
            App.UseCookiePolicy();

            App.UseMvc(ConfigureRoute);
        }

    }

}