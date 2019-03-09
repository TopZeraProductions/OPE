namespace WEB.AppInfra.Cookies.Interface {

    public interface ICookieServices {
        void WriteCookie(string key, string value, bool isPersistent = true);

        void ConcatCookie(string key, string value);

        string ReadCookie(string key);

        void DeleteCookie(string key);
    }

}