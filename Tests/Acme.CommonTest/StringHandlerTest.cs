using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //Arrange
            var source = "MyMelody";
            var expected = "My Melody";

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExisitingSpace()
        {
            //Arrange
            var source = "My Melody";
            var expected = "My Melody";

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
