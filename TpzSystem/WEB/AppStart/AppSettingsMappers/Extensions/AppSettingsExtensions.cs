using System;

using Microsoft.Extensions.Configuration;

namespace WEB.AppStart.AppSettingsMappers.Extensions {
    public static class AppSettingsExtension {
        public static T GetSectionMapped<T>(this IConfiguration Configuration) {
            // var name = nameof (T);
            var name = typeof(T).Name;
            
            Console.WriteLine("Getting AppService of > " + name);

            var Type = Configuration.GetSection(name).Get<T>();

            if (Type == null)
                Type = (T) Activator.CreateInstance(typeof (T));
            
            return Type;
        }
        
        public static string GetValue(this IConfiguration Configuration, string key) {
            Console.WriteLine(key +" ==> "+ Configuration[key]);
            
            return Configuration[key] ?? "";
        }
    }
}