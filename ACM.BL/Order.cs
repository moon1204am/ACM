using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order() : this(0)
        {
           
        }
        public Order(int orderId)
        {
            this.OrderId = orderId;
            this.OrderItems = new List<OrderItem>();
        }
        public int ustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItems { get; set; }

        public string Log() =>
            $"{OrderId}: Date: {this.OrderDate.Value.Date} Status: {EntityState.ToString()}";

        public override string ToString() =>
             $"{OrderDate.Value.Date} ({OrderId})";

        /// <summary>
        /// Validates the order.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
