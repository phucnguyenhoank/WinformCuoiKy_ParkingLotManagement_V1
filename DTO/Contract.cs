using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Contract
    {
        public string ContractID { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }
        public int RentalDurationInDays { get; set; }
        public int Price { get; set; }
        public int PaymentStatus { get; set; }

        public Contract(string contractID = "defaultID", DateTime rentalStartDate = default(DateTime), DateTime rentalEndDate = default(DateTime), int rentalDurationInDays = 0, int price = 0, int paymentStatus = 0)
        {
            ContractID = contractID;
            RentalStartDate = rentalStartDate;
            RentalEndDate = rentalEndDate;
            RentalDurationInDays = rentalDurationInDays;
            Price = price;
            PaymentStatus = paymentStatus;
        }
    }

}
