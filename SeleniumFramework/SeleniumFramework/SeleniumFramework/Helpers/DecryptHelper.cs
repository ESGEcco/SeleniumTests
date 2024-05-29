using System;
using System.Buffers.Text;
using System.Text;

namespace SeleniumFramework.SeleniumFramework.Helpers
{
    public class DecryptHelper
    {
        public string Decrypt(string decryptValue)
        {
            byte[] base64EncodedBytes = Convert.FromBase64String(decryptValue);

            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
