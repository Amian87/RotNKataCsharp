using System;
using System.Collections.Generic;

namespace RotNKata
{
    public class RotN
    {
        public string Encrypt(string plainText, int rotation)
        {
            List<string> letters = new List<string>();
            letters.Add("A");
            letters.Add("B");
            letters.Add("C");
            letters.Add("D");
            letters.Add("E");
            letters.Add("F");
            letters.Add("G");
            letters.Add("H");

            int letterIndex = letters.IndexOf(plainText);
            return letters[letterIndex - rotation];

        }
    }
}
