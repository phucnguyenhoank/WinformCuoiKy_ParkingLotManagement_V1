using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Job
    {
        public string JobID { get; set; }
        public string SpecializationID { get; set; }
        public string JobName { get; set; }
        public int JobValue { get; set; }
        public Job(string jobID = "defaultJobID", string specializationID = "defaultSpecializationID", string jobName = "defaultJobName", int jobValue = 0)
        {
            JobID = jobID;
            SpecializationID = specializationID;
            JobName = jobName;
            JobValue = jobValue;
        }
    }
}
