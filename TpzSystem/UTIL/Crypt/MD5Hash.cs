using System;
using System.Security.Cryptography;
using System.Text;

namespace UTIL.Crypt {

    public static class MD5Hash {
        public static string salt => "&!Tp25y573m2019#%";
        
        public static string Generate(string text) {
            MD5CryptoServiceProvider MD5provider = new MD5CryptoServiceProvider();
            StringBuilder            str         = new StringBuilder();
            
            text += salt;

            byte[] valorHash = MD5provider.ComputeHash(Encoding.Default.GetBytes(text));

            for (var i = 0; i < valorHash.Length; i++) {
                str.Append(valorHash[i].ToString("x2"));
            }

            return str.ToString();
        }

        public static bool Verify(string text, string Hashin) {

            string         Hash     = Generate(text);
            StringComparer Comparer = StringComparer.OrdinalIgnoreCase;

            if (Comparer.Compare(Hash, Hashin).Equals(0)) {
                
                return true;
            }

            return false;
        }
    }

}