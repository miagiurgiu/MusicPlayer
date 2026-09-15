using System;
using System.Security.Cryptography;

namespace MusicPlayer
{
    internal class PasswordHasher
    {
        public static string CreateHash(string password, out string salt)
        {
            // 1. Generate salt using standard .NET Framework RNGCryptoServiceProvider
            byte[] saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }

            // 2. Hash password using constructor instance of Rfc2898DeriveBytes
            byte[] hashBytes;
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 100000))
            {
                hashBytes = pbkdf2.GetBytes(32); // 32 bytes = SHA-256 equivalent output
            }

            salt = Convert.ToBase64String(saltBytes);
            return Convert.ToBase64String(hashBytes);
        }

        public static bool VerifyPassword(string password, string storedHash, string storedSalt)
        {
            byte[] saltBytes = Convert.FromBase64String(storedSalt);

            byte[] hashBytes;
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 100000))
            {
                hashBytes = pbkdf2.GetBytes(32);
            }

            string computedHash = Convert.ToBase64String(hashBytes);
            return computedHash == storedHash;
        }
    }
}