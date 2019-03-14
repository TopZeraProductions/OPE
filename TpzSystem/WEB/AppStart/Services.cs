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
        public void ConfigureServices(IServiceCollection Services) {
            /*Services.Configure<CookiePolicyOptions>(// for cookie police (only write cookies if client accept)
                options => {
                    options.CheckConsentNeeded    = context => true;
                    options.MinimumSameSitePolicy = SameSiteMode.None;
                }
            );*/

            Services.AddMvc(// for global filters
                options=> {
                    // options.Filters.Add(new LoggedFilter()); // instance
                    // options.Filters.Add(typeof(LoggedFilter)); // type
                }
            )
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            Services.AddHttpContextAccessor(); // injeta o contexto http fora das controllers

            Services.AddTransient<CookieServices, CookieServices>();
            Services.AddTransient<SessionUser, SessionUser>();
            Services.AddTransient<SessionServices, SessionServices>();
            Services.AddScoped<LoggedFilter>();
            Services.AddScoped<LoggedAccess>();
            
            Services.AddDistributedMemoryCache();
            Services.AddSession( // session configuration
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