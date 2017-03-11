using System;
using System.Security.Cryptography;
using DotNETHeroes.SecurityUtil.Converter;

namespace DotNETHeroes.SecurityUtil.Cryptography
{
    /// <summary>
    /// Implements a cryptographic and non-cryptographic Random Number Generator (RNG) 
    /// using the Guid 'Globally Unique Identifier' provided by the cryptographic service provider (CSP).
    /// </summary>
    public class Randomness
    {
        public enum GuidFormatSpecifier
        {
            DigitsOnly = 78, //N, 32 digits e.g. 00000000000000000000000000000000
            DigitsAndHyphens = 68, //D, 32 digits separated by hyphens e.g. 00000000-0000-0000-0000-000000000000
            DigitsHyphensAndBraces = 66, //B, 32 digits separated by hyphens, enclosed in braces e.g. {00000000-0000-0000-0000-000000000000}
            DigitsHyphensAndParentheses = 80, //P, 32 digits separated by hyphens, enclosed in parentheses e.g. (00000000-0000-0000-0000-000000000000)
            HexadecimalAndBraces = 88, //X, Four hexadecimal values enclosed in braces, where the fourth value is a subset of eight hexadecimal values that is also enclosed in braces e.g. {0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}
        }


        /// <summary>
        /// Generate a GUID string (32 hexadecimal digits / 128-bit values) with default format.
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// For more info about the format specifier https://msdn.microsoft.com/en-us/library/97af8hh4
        /// </remarks>
        public static string GenerateNewGuid()
        {
            return GenerateNewGuid(GuidFormatSpecifier.DigitsOnly);
        }
        public static string GenerateNewGuid(Randomness.GuidFormatSpecifier formatSpecifier)
        {
            return System.Guid.NewGuid().ToString(Convert.ToString((char)(int)formatSpecifier));
        }

        public static string RandomKey()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] key = new byte[15];
            rng.GetBytes(key);
            return BytesConverter.BytesToHex(key);

        }

      


    }
}

