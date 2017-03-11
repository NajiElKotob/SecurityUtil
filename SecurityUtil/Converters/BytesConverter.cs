using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETHeroes.SecurityUtil.Converter
{
   public static class BytesConverter
    {
        public static string BytesToHex(byte[] byteArray)
        {
            return BitConverter.ToString(byteArray).Replace("-", string.Empty).ToLower(); //e.g. 91aa5af59ec329d92c8bab1f4afb1f
        }

        public static string BytesToBase64(byte[] byteArray)
        {
            return Convert.ToBase64String(byteArray);
        }


    }
}
