using NUnit.Framework;
using RotNKata;
using System;
using System.Collections.Generic;

namespace RotNTests
{
    public class RotNTests
    {
        private RotN rn;

        [SetUp]
        public void SetUp()
        {
            List<string> capitalLetters = new List<string>();

            for(char c = 'A'; c <= 'Z'; c++)
            {
                capitalLetters.Add(c.ToString());
            }
            
            rn = new RotN(capitalLetters);
        }

        [Test]
        public void RotateLetterBBy1()
        {
            Assert.AreEqual("A", rn.Encrypt(1, "B"));
        }

        [Test]
        public void RotateLetterDBy2()
        {
            Assert.AreEqual("B", rn.Encrypt(2, "D"));
        }

        [Test]
        public void RotateLetterFBy2()
        {
            Assert.AreEqual("D", rn.Encrypt(2, "F"));
        }

        [Test]
        public void RotateLetterGBy2()
        {
            Assert.AreEqual("E", rn.Encrypt(2, "G"));
        }

        [Test]
        public void RotateLetterABy1()
        {
            Assert.AreEqual("Z", rn.Encrypt(1, "A"));
        }

        [Test]
        public void RotateMultipleLettersXBBy2()
        {
            Assert.AreEqual("VZ", rn.Encrypt(2, "XB"));
        }

        [Test]
        public void DecyptyLetterAWithRotation1()
        {
            Assert.AreEqual("B", rn.Decrypt(1, "A"));
        }

        [Test]
        public void DecyptyLetterCWithRotation2()
        {
            Assert.AreEqual("E", rn.Decrypt(2, "C"));
        }

        [Test]
        public void DecyptyLetterFWithRotation1()
        {
            Assert.AreEqual("G", rn.Decrypt(1, "F"));
        }

        [Test]
        public void DecyptyLetterGWithRotation2()
        {
            Assert.AreEqual("I", rn.Decrypt(2, "G"));
        }

        [Test]
        public void DecyptyLetterZWithRotation2()
        {
            Assert.AreEqual("B", rn.Decrypt(2, "Z"));
        }

        [Test]
        public void DecyptyMultipleLettersVZWithRotation2()
        {
            Assert.AreEqual("XB", rn.Decrypt(2, "VZ"));
        }

        [Test]
        public void ItEncryptsAndThenDecryptsAMessage()
        {
            string message = "CAPITALIZEDSTRING";
            int key = 5;

            Assert.AreEqual(message, rn.Decrypt(key, rn.Encrypt(key, message)));
        }

        [Test]
        public void ItEncryptsAndDecryptsANonTraditionalAlphabet()
        {
            List<string> customAlphabet = new List<string>();
            customAlphabet.Add("Q");
            customAlphabet.Add("w");
            customAlphabet.Add("4");
            customAlphabet.Add("~");
            customAlphabet.Add("?");
            customAlphabet.Add("V");

            RotN customRn = new RotN(customAlphabet);
            string message = "Q4~?V";
            int key = 4;

            string cipherText = customRn.Encrypt(key, message);
            string decryptedText = customRn.Decrypt(key, cipherText);

            Assert.AreEqual("4?VQw", cipherText);
            Assert.AreEqual(message, decryptedText);
        }

    }
}
