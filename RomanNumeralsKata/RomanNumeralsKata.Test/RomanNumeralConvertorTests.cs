using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumeralsKata.Tests
{
    [TestClass]
    public class RomanNumeralConvertorTests
    {
        [TestMethod]
        public void Given1ReturnI()
        {
            //Arrange
            int i = 1;
            RomanNumeralConvertor rnc = new RomanNumeralConvertor();

            // Act
            string rNumeral = rnc.ConvertToRomanNumeral(i);

            // Assert
            Assert.AreEqual(rNumeral, "I");
        }

        [TestMethod]
        public void Given2ReturnII()
        {
            //Arrange
            int i = 2;
            RomanNumeralConvertor rnc = new RomanNumeralConvertor();

            // Act
            string rNumeral = rnc.ConvertToRomanNumeral(i);

            // Assert
            Assert.AreEqual(rNumeral, "II");
        }

        [TestMethod]
        public void Given3ReturnIII()
        {
            //Arrange
            int i = 3;
            RomanNumeralConvertor rnc = new RomanNumeralConvertor();

            // Act
            string rNumeral = rnc.ConvertToRomanNumeral(i);

            // Assert
            Assert.AreEqual(rNumeral, "III");
        }

        //[TestMethod]
        //public void Given9ReturnIX()
        //{
        //    //Arrange
        //    int i = 9;
        //    RomanNumeralConvertor rnc = new RomanNumeralConvertor();

        //    // Act
        //    string rNumeral = rnc.ConvertToRomanNumeral(i);

        //    // Assert
        //    Assert.AreEqual(rNumeral, "IX");
        //}
    }
}
