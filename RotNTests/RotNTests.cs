using NUnit.Framework;
using RotNKata;
using System;

namespace RotNTests
{
    public class RotNTests
    {
        private RotN rn;

        [SetUp]
        public void SetUp()
        {
            rn = new RotN();

        }

        [Test]
        public void CreateCipher()
        {
            Assert.AreEqual("", rn.Encrypt(0, ""));
        }

        [Test]
        public void RotateByOne()
        {
            Assert.AreEqual("A", rn.Encrypt(1, "B"));
        }


        [Test]
        public void RotateByTwo()
        {
            Assert.AreEqual("A", rn.Encrypt(2, "C"));
        }

        [Test]
        public void RotateLetterCByOne()
        {
            Assert.AreEqual("B", rn.Encrypt(1, "C"));
        }

        [Test]
        public void RotateLetterDByThree()
        {
            Assert.AreEqual("A", rn.Encrypt(3, "D"));
        }

        [Test]
        public void RotateLetterZBy12()
        {
            Assert.AreEqual("N", rn.Encrypt(12, "Z"));
        }

        [Test]
        public void RotateLetterABy1()
        {
            Assert.AreEqual("Z", rn.Encrypt(1, "A"));
        }

        [Test]
        public void RotateLetterFBy7()
        {
            Assert.AreEqual("Y", rn.Encrypt(7, "F"));
        }

        [Test]
        public void RotateLetterFBy9()
        {
            Assert.AreEqual("W", rn.Encrypt(9, "F"));
        }

        [Test]
        public void RotateMultipleLettersBy5()
        {
            Assert.AreEqual("XB", rn.Encrypt(5, "CG"));
        }

        [Test]
        public void EncryptAndDecrypt()
        {
            string ciphertext = rn.Encrypt(10, "ABCDEFG");
            string plaintext = rn.Decrypt(10, ciphertext);
            Assert.AreEqual(plaintext, "ABCDEFG");
        }
    }
}
