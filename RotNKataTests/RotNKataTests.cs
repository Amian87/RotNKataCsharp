using NUnit.Framework;
using RotNKata;
using System;

namespace RotNKataTests
{
    public class RotNKataTests
    {
        private RotN rn;

        [SetUp]
        public void SetUpRotN()
        {
           rn = new RotN();
        }

        [Test]
        public void RotateLetterBBy1()
        {
            Assert.AreEqual("C", rn.Encrypt(1, "B"));
        }

        [Test]
        public void RotateLetterCBy2()
        {
            Assert.AreEqual("E", rn.Encrypt(2, "C"));
        }

        [Test]
        public void RotateLetterDBy2()
        {
            Assert.AreEqual("F", rn.Encrypt(2, "D"));
        }

        [Test]
        public void RotateLetterZBy1()
        {
            Assert.AreEqual("A", rn.Encrypt(1, "Z"));
        }

        [Test]
        public void RotateMultipleLettersAXBy3()
        {
            Assert.AreEqual("DA", rn.Encrypt(3, "AX"));
        }
            
    }
}
