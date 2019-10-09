using System;
using System.Collections.Generic;

namespace RotNKata
{
    public class RotN
    {
        public string Decrypt(int rotation, string cipherText)
        {
            string plainText = "";

            foreach (char c in cipherText)
            {
               plainText = string.Concat(plainText, DecryptSingleLetter(rotation, c.ToString())); 
            }
            return plainText;
        }

        private static string DecryptSingleLetter(int rotation, string cipherText)
        {
            List<string> alphabets = ListOfAlphabets();
            int alphabetIndex = alphabets.IndexOf(cipherText);

            if (alphabetIndex + rotation > alphabets.Count - 1)
            {
                return alphabets[alphabetIndex + rotation - alphabets.Count];
            }

            return alphabets[alphabetIndex + rotation];
        }

        public string Encrypt(int rotation, string plainText)
        {
            string encryptedText = "";

            foreach (char c in plainText)
            {
                encryptedText = string.Concat(encryptedText, EncryptSingleLetter(rotation, c.ToString())); 
            }

            return encryptedText;

        }

        private static string EncryptSingleLetter(int rotation, string plainText)
        {
            List<string> alphabets = ListOfAlphabets();
            int alpahbetIndex = alphabets.IndexOf(plainText);


            if (alpahbetIndex - rotation < 0)
            {
                return alphabets[alpahbetIndex - rotation + alphabets.Count];
            }

            return alphabets[alpahbetIndex - rotation];
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
