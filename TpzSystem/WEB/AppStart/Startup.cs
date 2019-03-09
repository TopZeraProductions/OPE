﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace WEB.AppStart {

    public partial class Startup {

        private IConfiguration Configuration { get; }

        public Startup(IConfiguration _Configuration) {
            Configuration = _Configuration;
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
            App.UseFileServer();

            App.UseMvc(ConfigureRoute);
        }
    }

}