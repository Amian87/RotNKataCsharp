using NUnit.Framework;
using RotNKata;
using System;

namespace RotNTests
{
    public class RotNTests
    {
        private RotN rn;

        [SetUp]
        public void Setup()
        {
            rn = new RotN();
        }

        [Test]
        public void RotateLetterBBy1()
        {
            RotN rn = new RotN();
            Assert.AreEqual("A", rn.Encrypt(1, "B"));
        }

        [Test]
        public void RotateLetterDBy2()
        {
            RotN rn = new RotN();
            Assert.AreEqual("B", rn.Encrypt(2, "D"));
        }

        [Test]
        public void RotateLetterGBy3()
        {
            RotN rn = new RotN();
            Assert.AreEqual("D", rn.Encrypt(3, "G"));
        }

        [Test]
        public void RotateLetterHBy3()
        {
            RotN rn = new RotN();
            Assert.AreEqual("E", rn.Encrypt(3, "H"));
        }

        [Test]
        public void RotateLetterBBy2()
        {
            RotN rn = new RotN();
            Assert.AreEqual("Z", rn.Encrypt(2, "B"));
        }

        [Test]
        public void RotateMultipleLettersXBBy3()
        {
            Assert.AreEqual("UY", rn.Encrypt(3, "XB"));
        }
    }
}
