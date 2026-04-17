using System;
using System.Security.Cryptography;
using System.Text;

namespace SportElemzes
{
    
    public static class JelszoKezelo
    {
        public static string KeszitHash(string jelszo)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(jelszo);
                var hashBytes = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        public static bool Ellenoriz(string jelszo, string eltaroltHash)
        {
            var aktualisHash = KeszitHash(jelszo);
            return StringComparer.Ordinal.Compare(aktualisHash, eltaroltHash) == 0;
        }
    }
}
