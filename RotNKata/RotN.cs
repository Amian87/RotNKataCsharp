using System.Collections.Generic;

namespace RotNKata
{
    public class RotN
    {
        private readonly List<string> alphabet;

        public RotN(List<string> alphabetToEncrypt)
        {
            alphabet = alphabetToEncrypt;
        }

        public string Encrypt(int rotation, string plainText)
        {
            string encryptedText = "";

            foreach (char c in plainText)
            {
                encryptedText = string.Concat(encryptedText, RotateSingleLetter(-rotation, c.ToString()));
            }

            return encryptedText;
        }

        public string Decrypt(int rotation, string cipherText)
        {
            return Encrypt(-rotation, cipherText);
        }

        private string RotateSingleLetter(int rotation, string cipherText)
        {
            int alphabetIndex = alphabet.IndexOf(cipherText);
            int rotatedIndex = ModWithNegative(alphabetIndex + rotation, alphabet.Count);
            return alphabet[rotatedIndex];
        }

        private int ModWithNegative(int num, int mod) {
            return ((num % mod) + mod) % mod;
        }
    }
}
