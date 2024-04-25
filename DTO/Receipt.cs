using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Receipt
    {
        public string ReceiptID { get; set; }
        public int TotalCost { get; set; }
        public string CustomerID { get; set; }
        public string ContractID { get; set; }

        public Receipt(string receiptID = "defaultID", int totalCost = 0, string customerID = "defaultCustomerID", string contractID = "defaultContractID")
        {
            ReceiptID = receiptID;
            TotalCost = totalCost;
            CustomerID = customerID;
            ContractID = contractID;
        }
    }
}
