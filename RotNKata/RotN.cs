using System;
using System.Collections.Generic;

namespace RotNKata
{
    public class RotN
    {
        public string Encrypt(string plainText, int rotation)
        {
            List<string> alphabet = Alphabet();
            int plainTextIndex = alphabet.IndexOf(plainText);
            string encryptedText = "";

            char[] charPlainText = plainText.ToCharArray();


            foreach(char letter in charPlainText)
            {
                encryptedText = string.Concat(encryptedText, SingleLetterEncryption(rotation, plainTextIndex, alphabet));
            }

            return encryptedText;
        }

        private static string SingleLetterEncryption(int rotation, int plainTextIndex, List<string> alphabet)
        {
            if (plainTextIndex - rotation < 0)
            {
                return alphabet[plainTextIndex - rotation + alphabet.Count];
            }
            else
            {
                return alphabet[plainTextIndex - rotation];
            }
        }

        private static List<string> Alphabet()
        {
            List<string> letters = new List<string>();

            for (char c = 'A'; c <= 'Z'; c++)
            {
                letters.Add(c.ToString());
            }

            return letters;
        }
    }
}
