using System;
using System.Security.Cryptography;
using System.Text;

namespace FusionSSH
{
    internal class DpapiHelper
    {
        /// <summary>
        /// Obfuscates string
        /// </summary>
        /// <param name="data">Text you want obfuscate</param>
        /// <returns>Obfuscated string</returns>
        public static string Protect(string data)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            byte[] protectedData = ProtectedData.Protect(dataBytes, null, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(protectedData);
        }

        /// <summary>
        /// De-obfuscates string.
        /// </summary>
        /// <param name="protectedData">Text you want de-obfuscate</param>
        /// <returns>Deobfuscated string</returns>
        public static string Unprotect(string protectedData)
        {
            byte[] protectedDataBytes = Convert.FromBase64String(protectedData);
            byte[] dataBytes = ProtectedData.Unprotect(protectedDataBytes, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(dataBytes);
        }
    }
}
