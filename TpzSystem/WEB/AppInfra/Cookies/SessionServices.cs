using Microsoft.AspNetCore.Http;

namespace WEB.AppInfra.Cookies {

    public class SessionServices {
        
        // Dependency
        private readonly HttpContext HttpContext;
        
        // Dependency injection
        public SessionServices(IHttpContextAccessor _IHttpContextAccessor) {
            HttpContext = _IHttpContextAccessor.HttpContext;
        }

        // metodo que escreve uma variavel pelo lado do servidor
        public void Write(string key, string value) {
            HttpContext.Session.SetString(key, value);
        }

        // metodo que escreve uma variavel pelo lado do servidor
        public void Concat(string key, string value) {
            var cookie = Read(key);
            cookie += value;
            Write(key, cookie);
        }

        public string Read(string key) {
            return HttpContext.Session.GetString(key);
        }
        
        public void Clear() {
            HttpContext.Session.Clear();
        }
    }
}