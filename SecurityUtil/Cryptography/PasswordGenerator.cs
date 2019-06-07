using System;


namespace DotNETHeroes.SecurityUtil.Cryptography
{
    /// <summary>
    /// Generate a strong random password
    /// </summary>
    /// <remarks>
    /// <seealso href="https://www.khanacademy.org/college-careers-more/personal-finance/keeping-your-information-safe/password-strength-and-other-strategies/v/math-behind-password-security">Math behind password security</see> 
    /// </remarks>


    public static class PasswordGenerator
    {

        private const string AlphabetLowerCase = "abcdefghijklmnopqrstuvwxyz"; // 26 characters
        private const string AlphabetUpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // 26 characters
        private const string Numbers = "0123456789"; // 10 characters
        private const string Symbols = @"!@#$%^&-"; // 8 characters

        public enum PasswordCharacterSet
        {
            Alphanumeric, // Lower and Upper case
            AlphanumericAndSymbols,
            Alphabetic,
            AlphabeticAndSymbols
        }


        public static string GenerateNewPassword(byte length,
           PasswordCharacterSet passwordCharacterSet = PasswordCharacterSet.AlphabeticAndSymbols,
            string Pattern = "")
        {

            //Valication
            //If the length of the requested password is less than 8 characters, throw an exception
            if (length < 8 == true)
            {
                throw new ArgumentException($"The requested passowrd is less than 8 characters," +
                    " the requested value is {length}");
            }

            var password = new char[length];
            var lastChar = new char();
            var currentChar = new char();

            var rnd = new Random();
            var pattern = Pattern;

            if (string.IsNullOrWhiteSpace(Pattern) == true)
            {
                switch (passwordCharacterSet)
                {
                    case PasswordCharacterSet.Alphanumeric:
                        pattern = AlphabetLowerCase + AlphabetUpperCase + Numbers;
                        break;
                    case PasswordCharacterSet.AlphanumericAndSymbols:
                        pattern = AlphabetLowerCase + AlphabetUpperCase + Numbers + Symbols;
                        break;
                    case PasswordCharacterSet.Alphabetic:
                        pattern = AlphabetLowerCase + AlphabetUpperCase;
                        break;
                    case PasswordCharacterSet.AlphabeticAndSymbols:
                        pattern = AlphabetLowerCase + AlphabetUpperCase  + Symbols;
                        break;
                    default://AlphanumericAndSymbols
                        pattern = AlphabetLowerCase + AlphabetUpperCase + Numbers + Symbols; 
                        break;
                }
            }


            for (int i = 0; i < length; i++)
            {
                currentChar = pattern[rnd.Next(0, pattern.Length)].ToString().ToCharArray()[0];
                password[i] = currentChar;
            }


            return string.Join(null, password);
        }
    }

}
