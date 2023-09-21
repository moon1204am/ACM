using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "mymelo@mariland.me",
                FirstName = "My",
                LastName = "Melody",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Flowers",
                Description = "Assorted Size Bouquet of 4 Bright Flowers",
                CurrentPrice = null,
            };
            changedItems.Add(product);

            //Act
            LoggingService.WriteToFile(changedItems);

            //Assert
            //Nothing here to assert
        }
    }
}
