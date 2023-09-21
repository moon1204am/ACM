using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public OrderRepository() { }

        /// <summary>
        /// Retrieve one order.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, 
                                                      new TimeSpan(7, 0, 0));
            }

            return order;
        }

        /// <summary>
        /// Saves the current order.
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            var success = true;
            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.isNew)
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
