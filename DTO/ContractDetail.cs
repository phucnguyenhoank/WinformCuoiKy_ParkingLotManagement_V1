using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ContractDetail
    {
        public string ContractID { get; set; }
        public string JobID { get; set; }
        public string CustomerID { get; set; }
        public decimal Wage { get; set; }
        public ContractDetail(string contractID = "defaultID", string jobID = "defaultJobID", string customerID = "defaultCustomerID", decimal wage = 0)
        {
            ContractID = contractID;
            JobID = jobID;
            CustomerID = customerID;
            Wage = wage;
        }
    }
}
