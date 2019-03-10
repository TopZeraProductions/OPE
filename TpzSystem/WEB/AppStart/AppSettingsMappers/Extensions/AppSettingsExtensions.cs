using System;

using Microsoft.Extensions.Configuration;

namespace WEB.AppStart.AppSettingsMappers.Extensions {
    public static class AppSettingsExtension {
        public static T GetSectionMapped<T>(this IConfiguration Configuration, string key) {
            return Configuration.GetSection(key).Get<T>();
        }
        
        public static string GetValue(this IConfiguration Configuration, string key) {
            Console.WriteLine(key +" ==> "+ Configuration[key]);
            
            return Configuration[key];
        }
    }
}