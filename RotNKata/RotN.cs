using System;
using System.Collections.Generic;

namespace RotNKata
{
    public class RotN
    {
        public string Encrypt(string plainText, int rotation)
        {
            //char[] charPlaintText = plainText.ToCharArray();

            //charPlaintText.

            List<string> listOfLetters = letterDictionary();

            int letterIndex = listOfLetters.IndexOf(plainText);
            return listOfLetters[letterIndex - rotation];
        }

        private static List<string> letterDictionary()
        {
            List<string> listOfLetters = new List<string>();

            for (char c = 'A'; c < 'Z'; c++)
            {
                listOfLetters.Add(c.ToString());
            }

        
            //listOfLetters.Add("A");
            //listOfLetters.Add("B");
            //listOfLetters.Add("C");
            //listOfLetters.Add("D");
            //listOfLetters.Add("E");
            //listOfLetters.Add("F");
            //listOfLetters.Add("G");
            //listOfLetters.Add("H");
            return listOfLetters;
        }
    }
}
