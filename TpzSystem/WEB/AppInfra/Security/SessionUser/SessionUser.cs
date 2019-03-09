using System.Extensions;

using UTIL.Crypt;

using WEB.AppInfra.Cookies.Interface;

namespace WEB.AppInfra.Security.SessionUser {

    public class SessionUser {
        public int id {
            get => CookieServices.ReadCookie("nuafsta").ToInt();
            set => CookieServices.WriteCookie("nuafsta", value.ToString());
        }

        public string idCrypt {
            get => CookieServices.ReadCookie("akkjasd");
            set => CookieServices.WriteCookie("akkjasd", MD5Hash.Generate(value));
        }

        public string name {
            get => CookieServices.ReadCookie("ghjakls");
            set => CookieServices.WriteCookie("ghjakls", value);
        }

        public string nameCrypt {
            get => CookieServices.ReadCookie("ratyuism");
            set => CookieServices.WriteCookie("ratyuism", MD5Hash.Generate(value));
        }

        // Dependency
        private readonly ICookieServices CookieServices;

        // Dependency injection
        public SessionUser(ICookieServices _ICookieServices) {

            CookieServices = _ICookieServices;
        }

    }

}