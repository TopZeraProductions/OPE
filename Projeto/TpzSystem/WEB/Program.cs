using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

using WEB.AppStart;

namespace WEB {

    public class Program {
        public static void Main(string[] args) {
            CreateWebHostBuilder(args).Build().Run();
        }

        private static IWebHostBuilder CreateWebHostBuilder(string[] args) {
            return WebHost.CreateDefaultBuilder(args)
                          .UseKestrel()
                          .UseWebRoot(Directory.GetCurrentDirectory())
                          .UseContentRoot(Directory.GetCurrentDirectory())
                          .UseStartup<Startup>();
        }
    }
}