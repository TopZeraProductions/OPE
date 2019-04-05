using System;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

using WEB.AppInfra.Cookies;
using WEB.AppInfra.Cookies.Service;
using WEB.AppInfra.Security.Filters;
using WEB.AppInfra.Security.SessionUserConfiguration;

namespace WEB.AppStart {

    public partial class Startup {
        // Essa classe serve para Definiçao de resoluçao de dependencias
        public void ConfigureServices(IServiceCollection services) {
            /*Services.Configure<CookiePolicyOptions>(// for cookie police (only write cookies if client accept)
                options => {
                    options.CheckConsentNeeded    = context => true;
                    options.MinimumSameSitePolicy = SameSiteMode.None;
                }
            );*/

            services.AddMvc(// for global filters
                options=> {
                    // options.Filters.Add(new LoggedFilter()); // instance
                    // options.Filters.Add(typeof(LoggedFilter)); // type (if need DI)
                }
            )
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            services.AddHttpContextAccessor(); // injeta o contexto http fora das controllers

            services.AddTransient<CookieServices, CookieServices>();
            services.AddTransient<SessionUser, SessionUser>();
            services.AddTransient<SessionServices, SessionServices>();
            services.AddScoped<LoggedFilter>();
            services.AddScoped<LoggedAccess>();
            
            services.AddDistributedMemoryCache();
            
            services.AddSession( // session configuration
                options => {
                    options.Cookie.Name         = "tpz_session";
                    options.Cookie.HttpOnly     = true;
                    options.IdleTimeout         = TimeSpan.FromDays(3);
                    options.Cookie.IsEssential  = true;
                    options.Cookie.SameSite     = SameSiteMode.Strict;
                }
            );
        }
    }
}