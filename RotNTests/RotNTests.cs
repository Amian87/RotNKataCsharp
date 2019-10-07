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
        public void RotateLetterCBy1()
        {
            Assert.AreEqual("B", rn.Encrypt(1, "C"));
        }

        [Test]
        public void RotateLetterDBy3()
        {
            Assert.AreEqual("A", rn.Encrypt(3, "D"));
        }

        [Test]
        public void RotateLetterEBy1()
        {
            Assert.AreEqual("D", rn.Encrypt(1, "E"));
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
        public void RotateMulitpleLettersXBBy2()
        {
            Assert.AreEqual("VZ", rn.Encrypt(2, "XB"));
        }


    }
}
