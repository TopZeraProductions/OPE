using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace WEB.AppStart {

    partial class Startup {
        // esse metodo serve para iniciar os servicos no pipeline
        public void Configure(IApplicationBuilder app,
                              IHostingEnvironment env) {

            if (env.IsDevelopment()) { // caso a variavel de ambiente seja de dev
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }

            if (env.IsProduction()
                || env.IsStaging()) { // caso a variavel de ambiente seja de stagging ou Production

                app.UseExceptionHandler("/errors/error/error");
                app.UseStatusCodePagesWithRedirects("/errors/error/errorcode?errorCode={0}");

                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseFileServer();
            app.UseSession();

            app.UseMvc(ConfigureRoute); //Configuraçao das rotas
        }
    }

}