using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;

namespace Project.Common.Helpers
{

    public static class PasswordHelper
    {
        public static string CreateRandomSalt()
        {
            byte[] saltByte;

            // generate a 128-bit salt using a secure PRNG
            saltByte = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
                rng.GetBytes(saltByte);
            var salt = Convert.ToBase64String(saltByte);

            return salt;
        }

        public static string CreateHashed(string password, string salt)
        {
            if (salt == null)
                throw new Exception();

            byte[] saltByte = Convert.FromBase64String(salt);

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            var hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: saltByte,
                prf: KeyDerivationPrf.HMACSHA512,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return hashed;
        }
    }
}
