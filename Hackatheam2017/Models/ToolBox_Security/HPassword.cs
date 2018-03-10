using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Inscription.Models.ToolBox_Security
{
    public class HPassword
    {
        public static byte[] HashPassword(string password)
        {
            var provider = new SHA1CryptoServiceProvider();
            var encoding = new UnicodeEncoding();
            return provider.ComputeHash(encoding.GetBytes(password));
        }

        private string[] getByteStringFromByteArray(byte[] value)
        {
            // Conversion of the byte array to a string 
            String infos = BitConverter.ToString(value);
            // a char array to use the "-" caracter as a separator 
            char[] tiret = new char[1];
            tiret[0] = '-';
            return infos.Split(tiret);
        }
    }
}