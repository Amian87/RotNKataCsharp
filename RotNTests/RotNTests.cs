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
        public void RotateLetterABy1()
        {
            Assert.AreEqual("A", rn.Encrypt("B", 1));
        }

        [Test]
        public void RotateLetterDBy2()
        {
            Assert.AreEqual("F", rn.Encrypt("H", 2));
        }

        [Test]
        public void RotateLetterFBy3()
        {
            Assert.AreEqual("C", rn.Encrypt("F", 3));
        }

        [Test]
        public void RotateLetterIBy4()
        {
            Assert.AreEqual("E", rn.Encrypt("I", 4));
        }

    }
}
