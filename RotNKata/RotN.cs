using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RotNKata
{
    public class RotN
    {

        public string Encrypt(int rot, string text)
        {
            char[] splitString = text.ToCharArray();
            string encryptedText = "";

            foreach (char letter in splitString) 
            {
                encryptedText = string.Concat(encryptedText, EncryptSingleLetter(rot, letter.ToString()));
            }
            return encryptedText;
        }

        public string Decrypt(int rot, string text)
        {
            return Encrypt(-rot, text);
        }

        public string EncryptSingleLetter(int rot, string text)
        {
            if(String.IsNullOrEmpty(text)) return "";
            List<string> alphabet = Alphabet();
            int indexOfLetter = alphabet.IndexOf(text);
            return alphabet[IndexOfCipherLetter(indexOfLetter, rot)];
        }

        private int IndexOfCipherLetter(int indexOfPlaintextLetter, int rot)
        {
            if(indexOfPlaintextLetter - rot < 0)
            {
                return indexOfPlaintextLetter - rot + Alphabet().Count;
            }
            else
            {
                return indexOfPlaintextLetter - rot;
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
