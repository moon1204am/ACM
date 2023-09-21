using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {
            
        }
        public Product(int productId)
        {
            this.ProductId = productId;
        }
        private string productName;

        public string ProductName
        {
            get 
            {
                return productName.InsertSpaces(); 
            }
            set { productName = value; }
        }

        public string Description { get; set; }
        public int ProductId { get; private set; }
        public decimal? CurrentPrice { get; set; }

        public string Log() =>
            $"{ProductId}: {ProductName} Detail: {Description} Status: {EntityState.ToString()}";

        public override string ToString() => ProductName;

        /// <summary>
        /// Validates product.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
