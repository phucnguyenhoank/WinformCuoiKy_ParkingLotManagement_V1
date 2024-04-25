using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RentalContract
    {
        public string ContractID { get; set; }
        public string Renter { get; set; }

        public RentalContract(string contractID = "defaultID", string renter = "defaultRenter")
        {
            ContractID = contractID;
            Renter = renter;
        }
    }
}
