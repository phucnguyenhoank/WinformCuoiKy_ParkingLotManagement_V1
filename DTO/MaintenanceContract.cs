using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MaintenanceContract
    {
        public string ContractID { get; set; }
        public int WarrantyDurationInMonths { get; set; }

        public MaintenanceContract(string contractID = "defaultID", int warrantyDurationInMonths = 0)
        {
            ContractID = contractID;
            WarrantyDurationInMonths = warrantyDurationInMonths;
        }
    }
}
