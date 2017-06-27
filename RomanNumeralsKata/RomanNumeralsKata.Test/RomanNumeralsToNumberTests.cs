using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumeralsKata.Tests
{
    [TestClass]
    public class RomanNumeralsToNumberTests
    {
        [TestMethod]
        public void GivenIReturn1()
        {
            //Arrange
            string i = "I";
            RomanNumeralsToNumber rnn = new RomanNumeralsToNumber();

            // Act
            string rNumber = rnn.ConvertToNumber(i);

            // Assert
            Assert.AreEqual(rNumber, "1");
        }

        [TestMethod]
        public void GivenIIIReturn3()
        {
            //Arrange
            string i = "III";
            RomanNumeralsToNumber rnn = new RomanNumeralsToNumber();

            // Act
            string rNumber = rnn.ConvertToNumber(i);

            // Assert
            Assert.AreEqual(rNumber, "3");
        }

        [TestMethod]
        public void GivenIXReturn9()
        {
            //Arrange
            string i = "IX";
            RomanNumeralsToNumber rnn = new RomanNumeralsToNumber();

            // Act
            string rNumber = rnn.ConvertToNumber(i);

            // Assert
            Assert.AreEqual(rNumber, "9");
        }

        [TestMethod]
        public void GivenMLXVIReturn1066()
        {
            //Arrange
            string i = "MLXVI";
            RomanNumeralsToNumber rnn = new RomanNumeralsToNumber();

            // Act
            string rNumber = rnn.ConvertToNumber(i);

            // Assert
            Assert.AreEqual(rNumber, "1066");
        }

        [TestMethod]
        public void GivenMCMLXXXIXReturn1989()
        {
            //Arrange
            string i = "MCMLXXXIX";
            RomanNumeralsToNumber rnn = new RomanNumeralsToNumber();

            // Act
            string rNumber = rnn.ConvertToNumber(i);

            // Assert
            Assert.AreEqual(rNumber, "1989");
        }
    }
}
