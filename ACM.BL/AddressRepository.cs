using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    internal class AddressRepository
    {
        public AddressRepository() { }

        /// <summary>
        /// Retrieve one address.
        /// </summary>
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Mariland End";
                address.StreetLine2 = "Mariland row";
                address.City = "Mariland";
                address.State = "Marigold";
                address.Country = "Mari";
                address.PostalCode = "12345";
                    
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId) 
        { 
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Mariland End",
                StreetLine2 = "Mariland row",
                City = "Mariland",
                State = "Marigold",
                Country = "Mari",
                PostalCode = "12345",
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Almond Pound",
                StreetLine2 = "Flower field",
                City = "Mariland",
                State = "Marigold",
                Country = "Mari",
                PostalCode = "54321",
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Saves the current address.
        /// </summary>
        /// <returns></returns>
        public bool Save(Address address)
        {
            var success = true;
            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.isNew)
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
