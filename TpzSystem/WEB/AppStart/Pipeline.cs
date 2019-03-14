using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace WEB.AppStart {

    partial class Startup {
        // esse metodo serve para iniciar os servicos no pipeline
        public void Configure(IApplicationBuilder App,
                              IHostingEnvironment Env) {

            if (Env.IsDevelopment()) { // caso a variavel de ambiente seja de dev
                App.UseDeveloperExceptionPage();
                App.UseStatusCodePages();
            }

            if (Env.IsProduction()
                || Env.IsStaging()) { // caso a variavel de ambiente seja de stagging ou Production

                App.UseExceptionHandler("/errors/error/error");
                App.UseStatusCodePagesWithRedirects("/errors/error/errorcode?errorCode={0}");

                App.UseHsts();
            }

            App.UseHttpsRedirection();
            App.UseStaticFiles();
            App.UseCookiePolicy();
            App.UseFileServer();
            App.UseSession();

            App.UseMvc(ConfigureRoute); //Configuraçao das rotas
        }
    }

}