using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }
        public CustomerRepository() 
        { 
            addressRepository = new AddressRepository();
        }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if(customerId == 1)
            {
                customer.EmailAddress = "mymelo@mariland.me";
                customer.FirstName = "My";
                customer.LastName = "Melody";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        /// <summary>
        /// Retrieve all customers.
        /// </summary>
        /// <returns></returns>
        public IList<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            var success = true;
            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.isNew)
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
