using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public ProductRepository() { }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Flowers";
                product.Description = "Assorted Size Bouquet of 4 Bright Flowers";
                product.CurrentPrice = 100.12m;
            }
            Object obj = new Object();
            Console.WriteLine(obj.ToString());
            Console.WriteLine(product.ToString());


            return product;
        }

        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            var success = true;
            if(product.HasChanges)
            {
                if(product.IsValid) 
                { 
                    if(product.isNew) 
                    { 
                        //Call an insert Stores Procedure
                    } 
                    else
                    {
                        //CALL an Update Stored Procedure
                    }
                } 
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
