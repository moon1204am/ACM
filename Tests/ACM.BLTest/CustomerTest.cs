using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "My",
                LastName = "Melo"
            };

            string expected = "Melo, My";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            Customer customer = new Customer
            {
                LastName = "Melo"
            };

            string expected = "Melo";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "My"
            };

            string expected = "My";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            var c1 = new Customer();
            c1.FirstName = "Kuromi";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Cinnamonroll";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Purin";
            Customer.InstanceCount += 1;


            int expected = 3;

            //Act
            int actual = Customer.InstanceCount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            var customer = new Customer
            {
                LastName = "Melo",
                EmailAddress = "mymelo@mariland.me"
            };

            var expected = true;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //Arrange
            var customer = new Customer
            {
                EmailAddress = "mymelo@mariland.me"
            };

            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
