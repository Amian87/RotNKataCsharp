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
        public void RotateLetterGBy2()
        {
            Assert.AreEqual("E", rn.Encrypt(2, "G"));
        }

        [Test]
        public void RotateLetterHBy2()
        {
            Assert.AreEqual("F", rn.Encrypt(2, "H"));
        }

        [Test]
        public void RotateLetterABy1()
        {
            Assert.AreEqual("Z", rn.Encrypt(1, "A"));
        }

        [Test]
        public void EncryptMultipleLettersXBBy2()
        {
            Assert.AreEqual("VZ", rn.Encrypt(2, "XB"));
        }

    }
}
