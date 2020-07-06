using System;
using System.Net.Security;
using NUnit.Framework;

namespace RotNKata.Test
{
    public class RotNTest
    {
        private RotN rotN;

        [SetUp]
        public void SetUpRotN()
        {
            rotN = new RotN();
        }

        [Test]
        public void RotateLetterBByOne()
        {
            Assert.AreEqual("A", rotN.Encrypt("B", 1));
        }

        [Test]
        public void RotateLetterDByTwo()
        {
            Assert.AreEqual("B", rotN.Encrypt("D", 2));
        }

        [Test]
        public void RotateLetterDByThree()
        {
            Assert.AreEqual("A", rotN.Encrypt("D", 3));
        }

        [Test]
        public void RotateMultipleLettersBy5()
        {
            Assert.AreEqual("XB", rotN.Encrypt("CG", 5));
        }

    }
}
