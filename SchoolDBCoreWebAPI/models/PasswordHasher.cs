using System.Text;
using System.Security.Cryptography;

namespace SchoolDBCoreWebAPI.models
{
    public static  class Passwordhasher
    {
        public static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes=Encoding.UTF8.Bytes(password);
            var hash=sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);

        }

        public static bool verifyPassword(string hashdPassword,string providedPassword)
        {
            return hashdPassword == HashPassword(providedPassword);
        }
    }
}
