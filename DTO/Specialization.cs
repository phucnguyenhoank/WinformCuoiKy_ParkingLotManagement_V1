using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Specialization
    {
        public string SpecializationID { get; set; }
        public string SpecializationName { get; set; }

        public Specialization(string specializationID = "defaultID", string specializationName = "defaultName")
        {
            SpecializationID = specializationID;
            SpecializationName = specializationName;
        }
    }
}
