using System.Collections.Generic;

public class RotN
{
    public string Encrypt(string plainText, int rotation)
    {
        char[] plainTextCharArray = plainText.ToCharArray();
        string encryptedText = "";

        foreach (var letter in plainTextCharArray)
        {
            encryptedText = string.Concat(encryptedText, EncryptSingleLetter(rotation, letter.ToString()));
        }

        return encryptedText;
    }

    private static string EncryptSingleLetter(int rotation, string plainText)
    {
        List<string> alphabets = Alphabets();
        int plainTextIndex = alphabets.IndexOf(plainText);

        if (plainTextIndex - rotation < 0)
        {
            return alphabets[plainTextIndex - rotation + alphabets.Count];
        }
        else
        {
            return alphabets[plainTextIndex - rotation];
        }
    }

    private static List<string> Alphabets()
    {
        List<string> alphabets = new List<string>();

        for (char c = 'A'; c <= 'Z'; c++)
        {
            alphabets.Add(c.ToString());
        }

        return alphabets;
    }
}