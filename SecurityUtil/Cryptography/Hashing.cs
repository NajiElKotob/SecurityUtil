using DotNETHeroes.SecurityUtil.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DotNETHeroes.SecurityUtil.Cryptography
{
    public enum HashAlgorithmEnum
    {
        None,
        MD5,
        SHA1,
        SHA256,
        SHA384,
        SHA512
    }

    public enum FormatEnum
    {
        Base64,
        Hex
    }

    
    public static class Hashing
    {

            /// <summary>
            /// Compute a hash for the given plain text value and returns a hashed string
            /// in base-64 (Default) or Hex format.
            /// </summary>
            /// <remarks>
            /// HashAlgorithm Class https://msdn.microsoft.com/en-us/library/system.security.cryptography.hashalgorithm(v=vs.110).aspx
            /// Convert.ToBase64String Method https://msdn.microsoft.com/en-us/library/dhx0d524
            /// </remarks>
            public static string ComputeHash(string plainText,
                                        HashAlgorithmEnum hashAlgorithm,
                                        FormatEnum format = FormatEnum.Base64
                                        )
        {

            // Cryptographic hash algorithms base-class 
            HashAlgorithm hash;


            // Initialize the hashing algorithm class.
            switch (hashAlgorithm)
            {
                case HashAlgorithmEnum.MD5:
                    hash = new MD5CryptoServiceProvider();
                    break;

                case HashAlgorithmEnum.SHA1:
                    hash = new SHA1Managed();
                    break;

                case HashAlgorithmEnum.SHA256:
                    hash = new SHA256Managed();
                    break;

                case HashAlgorithmEnum.SHA384:
                    hash = new SHA384Managed();
                    break;

                case HashAlgorithmEnum.SHA512:
                    hash = new SHA512Managed();
                    break;

                default:
                    hash = new MD5CryptoServiceProvider();
                    break;
            }


            byte[] hashBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(plainText));

            // Convert result into a hex or base64 string.
            string hashValue;

            if (format == FormatEnum.Hex)
            {         
                hashValue = BytesConverter.BytesToHex(hashBytes);
            }
            else
            {
                hashValue = BytesConverter.BytesToBase64(hashBytes);
            }

            return hashValue;
        }

    }
}
