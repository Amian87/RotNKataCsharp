using System;
using System.Collections.Generic;

namespace RotNKata
{
    public class RotN
    {
        public string Encrypt(int rotatation, string plainText)
        {
            string encryptedText = "";

            foreach(char c in plainText)
            {
                encryptedText = string.Concat(encryptedText,EncryptSingleLetter(rotatation, c.ToString()));
            }

            return encryptedText;
        }

        private static string EncryptSingleLetter(int rotatation, string plainText)
        {
            List<string> alphabets = ListOfAlphabets();
            int alphabetIndex = alphabets.IndexOf(plainText);

            if (alphabetIndex + rotatation - alphabets.Count >= 0)
            {
                return alphabets[alphabetIndex + rotatation - alphabets.Count];
            }
            else
            {
                return alphabets[alphabetIndex + rotatation];
            }
        }

        private static List<string> ListOfAlphabets()
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