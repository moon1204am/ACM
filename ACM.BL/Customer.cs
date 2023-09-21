using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer(): this(0)
        {
				
        }
        public Customer(int customerId)
        {
				this.CustomerId = customerId;
				AddressList = new List<Address>();
        }

        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public int CustomerType { get; set; }
        public List<Address> AddressList { get; set; }

		public string FullName
		{
			get 
			{
				string fullName = LastName;
				if(!string.IsNullOrWhiteSpace(FirstName)) 
				{ 
					if(!string.IsNullOrWhiteSpace(fullName)) 
					{
						fullName += ", ";
					}
					fullName += FirstName;
				}
				return fullName; 
			}
		}

		private string _lastName;
		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}

        public static int InstanceCount { get; set; }

		public string Log() =>
			$"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

		public override string ToString() => FullName;

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
		{
			var isValid = true;
			if (string.IsNullOrEmpty(LastName)) isValid = false;
			if (string.IsNullOrEmpty(EmailAddress)) isValid = false;

			return isValid;
		}
    }
}
