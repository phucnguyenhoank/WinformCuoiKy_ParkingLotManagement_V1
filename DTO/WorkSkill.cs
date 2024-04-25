using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WorkSkill
    {
        public string EmployeeID { get; set; }
        public string JobID { get; set; }

        public WorkSkill(string employeeID = "defaultEmployeeID", string jobID = "defaultJobID")
        {
            EmployeeID = employeeID;
            JobID = jobID;
        }
    }
}
