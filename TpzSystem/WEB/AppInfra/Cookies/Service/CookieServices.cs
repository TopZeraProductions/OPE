using System;

using Microsoft.AspNetCore.Http;

using WEB.AppInfra.Cookies.Interface;

namespace WEB.AppInfra.Cookies.Service {

    public class CookieServices : ICookieServices{
        
        // Dependency
        private readonly HttpContext HttpContext;
        
        // Dependency injection
        public CookieServices(IHttpContextAccessor _IHttpContextAccessor) {
            HttpContext = _IHttpContextAccessor.HttpContext;
        }

        public void WriteCookie(string key, string value, bool isPersistent = true) {
            if (isPersistent) {
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.Now.AddDays(5);

                HttpContext.Response.Cookies.Append(key, value, options);
            } else {

                HttpContext.Response.Cookies.Append(key, value);
            }
        }

        public void ConcatCookie(string key, string value) {
            var cookie = ReadCookie(key);
            cookie += value;
            WriteCookie(key, cookie);
        }

        public string ReadCookie(string key) {
            return HttpContext.Request.Cookies[key] ?? "";
        }

        public void DeleteCookie(string key) {

            HttpContext.Response.Cookies.Delete(key);
        }
    }
}