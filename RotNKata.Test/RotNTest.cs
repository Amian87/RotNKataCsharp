using System;
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
        public void RotateLetterAByOne()
        {
            Assert.AreEqual("A", rotN.Encrypt("B", 1));
        }

        [Test]
        public void RotateLetterByTwo()
        {
            Assert.AreEqual("F", rotN.Encrypt("H", 2) );
        }

        [Test]
        public void RotateLetterByThree()
        {
            Assert.AreEqual("C", rotN.Encrypt("F", 3));
        }

        [Test]
        public void RotateLetterIByFour()
        {
            Assert.AreEqual("E", rotN.Encrypt("I", 4));
        }

        [Test]
        public void RotateMultipleLettersByFive()
        {
            Assert.AreEqual("XB", rotN.Encrypt("CG", 5));
        }

    }
}
