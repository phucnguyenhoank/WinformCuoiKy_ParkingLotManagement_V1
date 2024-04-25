using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string Name { get; set; }
        public string CitizenNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public Customer(string customerID = "defaultID", string name = "defaultName", string citizenNumber = "defaultCitizenNumber", string phoneNumber = "defaultPhoneNumber", string address = "defaultAddress")
        {
            CustomerID = customerID;
            Name = name;
            CitizenNumber = citizenNumber;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }

}
