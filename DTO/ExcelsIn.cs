using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExcelsIn
    {
        public string EmployeeID { get; set; }
        public string SpecializationID { get; set; }
        public ExcelsIn(string employeeID = "defaultEmployeeID", string specializationID = "defaultSpecializationID")
        {
            EmployeeID = employeeID;
            SpecializationID = specializationID;
        }
    }
}
