using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ContractSigning
    {
        public string VehicleID { get; set; }
        public string ContractID { get; set; }
        public ContractSigning(string vehicleID = "defaultVehicleID", string contractID = "defaultContractID")
        {
            VehicleID = vehicleID;
            ContractID = contractID;
        }
    }
}
