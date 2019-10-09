using System.Collections.Generic;

namespace RotNKata
{
    public class RotN
    {
        private readonly List<string> alphabet;

        public RotN() 
        {
            alphabet = ListOfAlphabets();
        }

        public string Encrypt(int rotation, string plainText)
        {
            string normalizePlainText = plainText.ToUpper();
            string encryptedText = "";

            foreach (char c in normalizePlainText)
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

            if (IndexTooLarge(alphabetIndex, rotation))
            {
                return alphabet[alphabetIndex + rotation - alphabet.Count];
            }
            else if (IndexTooSmall(alphabetIndex, rotation))
            {
                return alphabet[alphabetIndex + rotation + alphabet.Count];
            }
            else
            {
                return alphabet[alphabetIndex + rotation];
            }
        }

        private bool IndexTooLarge(int alphabetIndex, int rotation) 
        {
            return alphabetIndex + rotation > alphabet.Count - 1;
        }

        private bool IndexTooSmall(int alphabetIndex, int rotation)
        {
            return alphabetIndex + rotation < 0;
        }

        private List<string> ListOfAlphabets()
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
