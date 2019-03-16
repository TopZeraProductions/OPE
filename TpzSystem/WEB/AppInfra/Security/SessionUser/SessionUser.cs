using System.Extensions;

using UTIL.Crypt;

using WEB.AppInfra.Cookies;
using WEB.AppInfra.Cookies.Service;

namespace WEB.AppInfra.Security.SessionUserConfiguration {

    public class SessionUser {
        // Dependency
        private readonly CookieServices  CookieServices;
        private readonly SessionServices SessionServices;

        // Dependency injection
        public SessionUser(CookieServices  _CookieServices,
                           SessionServices _SessionServices) {
            
            CookieServices  = _CookieServices;
            SessionServices = _SessionServices;
        }
            
        public int id {
            get {
                var client = CookieServices.Read("tpz_nuafsta");
                var server = SessionServices.Read("tpz_nuafsta").ToInt();

                if (MD5Hash.Verify(server.ToString(), client)) {
                    return server;
                }
                return 0;
            }
            set {
                CookieServices.Write("tpz_nuafsta", MD5Hash.Generate(value.ToString()));
                SessionServices.Write("tpz_nuafsta", value.ToString());
            } 
        }

        public string name {
            get => CookieServices.Read("tpz_ghjakls");
            set => CookieServices.Write("tpz_ghjakls", value);
        }

        public string nameCrypt {
            get => CookieServices.Read("tpz_ratyuism");
            set => CookieServices.Write("tpz_ratyuism", MD5Hash.Generate(value));
        }

        public bool IsLogged() {
            return id > 0;
        }
        
        public void ClearSessions() {
            CookieServices.Delete("tpz_nuafsta");
            SessionServices.Clear();
        }
    }
}