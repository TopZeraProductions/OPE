using System;

using Microsoft.AspNetCore.Http;

namespace WEB.AppInfra.Cookies.Service {

    public class CookieServices {
        
        // Dependency
        private readonly HttpContext HttpContext;
        
        // Dependency injection
        public CookieServices(IHttpContextAccessor _IHttpContextAccessor) {
            HttpContext = _IHttpContextAccessor.HttpContext;
        }

        public void Write(string key, string value, bool isPersistent = true) {
            if (isPersistent) {
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.Now.AddDays(5);

                HttpContext.Response.Cookies.Append(key, value, options);
            } else {

                HttpContext.Response.Cookies.Append(key, value);
            }
        }

        public void Concat(string key, string value) {
            var cookie = Read(key);
            cookie += value;
            Write(key, cookie);
        }

        public string Read(string key) {
            return HttpContext.Request.Cookies[key] ?? "";
        }

        public void Delete(string key) {
            HttpContext.Response.Cookies.Delete(key);
        }
    }
}