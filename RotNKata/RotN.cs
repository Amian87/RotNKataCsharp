using System;
using System.Collections.Generic;

namespace RotNKata
{
    public class RotN
    {
        public string Encrypt(int rotation, string plainText)
        {
            string encryptedText = "";

            foreach(char c in plainText)
            {
                encryptedText = string.Concat(encryptedText, EncryptSingleLetter(rotation, c.ToString()));
            }
            return encryptedText;

        }

        private static string EncryptSingleLetter(int rotation, string plainText)
        {
            List<string> alphabets = listOfAlphabets();
            int alphabetIndex = alphabets.IndexOf(plainText);

            if (alphabetIndex - rotation < 0)
            {
                return alphabets[alphabetIndex - rotation + alphabets.Count];
            }

            return alphabets[alphabetIndex - rotation];
        }

        private static List<string> listOfAlphabets()
        {
            List<string> alphabets = new List<string>();

            for(char c = 'A'; c <= 'Z'; c++)
            {
                alphabets.Add(c.ToString());
            }

            return alphabets;
        }
    }
}
