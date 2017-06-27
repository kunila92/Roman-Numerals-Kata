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
    }
}
