using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using WEB.AppStart.AppSettingsMappers;
using WEB.AppStart.AppSettingsMappers.Extensions;

namespace WEB.AppStart {

    public partial class Startup {

        private IConfiguration Configuration { get; }
        
        // recebe as configuracoes do appsettings.json
        public Startup(IConfiguration _Configuration) {
            
            Configuration = _Configuration;

            var logPath     = Configuration.GetValue("logPath");
            var urlServices = Configuration.GetValue("urlServices");
            var ApiAuth     = Configuration.GetValue("ApiAuth");
        }
    }

}