using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Flowers",
                Description = "Assorted Size Bouquet of 4 Bright Flowers",
                CurrentPrice = 100.12m
            };

            //Act
            var actual = productRepository.Retrieve(2);

            //Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updatesProduct = new Product(2)
            {
                ProductName = "Flowers",
                Description = "Assorted Size Bouquet of 4 Bright Flowers",
                CurrentPrice = 180M,
                HasChanges = true
            };

            //Act
            var actual = productRepository.Save(updatesProduct);

            //Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updatesProduct = new Product(2)
            {
                ProductName = "Flowers",
                Description = "Assorted Size Bouquet of 4 Bright Flowers",
                CurrentPrice = null,
                HasChanges = true
            };

            //Act
            var actual = productRepository.Save(updatesProduct);

            //Assert
            Assert.AreEqual(false, actual);
        }
    }
}
