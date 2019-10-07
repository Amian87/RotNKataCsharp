using System;
using System.Collections.Generic;

namespace RotNKata
{
    public class RotN
    {
        public string Encrypt(int rotation, string plainText)
        {
            char[] charPlainText = plainText.ToCharArray();

            string encryptedText = "";

            foreach (char c in charPlainText)
            {
                encryptedText = string.Concat(encryptedText, encryptSingleLetter(rotation, c.ToString()));
            }
            return encryptedText;
        }

        private static string encryptSingleLetter(int rotation, string plainText)
        {
            List<string> alphabets = listOfAlphabets();
            int alphabetIndex = alphabets.IndexOf(plainText);

            if (alphabetIndex - 1 < 0)
            {
                return alphabets[alphabetIndex - rotation + alphabets.Count];
            }
            else
            {

                return alphabets[alphabetIndex - rotation];
            }
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
