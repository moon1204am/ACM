using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem : EntityBase
    {
        public OrderItem()
        {
                
        }
        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Retrieves one product.
        /// </summary>
        /// <returns></returns>
        public OrderItem Retrieve()
        {
            return new OrderItem();
        }

        /// <summary>
        /// Saves current product.
        /// </summary>
        /// <returns></returns>
        public bool Save(OrderItem orderItem)
        {
            var success = true;
            if (orderItem.HasChanges)
            {
                if (orderItem.IsValid)
                {
                    if (orderItem.isNew)
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

        /// <summary>
        /// Validates product.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if(ProductId <= 0) isValid = false;
            if(PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
