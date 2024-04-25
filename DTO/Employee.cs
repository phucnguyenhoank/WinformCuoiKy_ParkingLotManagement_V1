using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employee
    {
        public string EmployeeID { get; set; }
        public string EmployeeType { get; set; }
        public string EmployeeName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Employee(string employeeID = "defaultID", string employeeType = "defaultType", string employeeName = "defaultName", DateTime birthDay = default(DateTime), string gender = "defaultGender", string address = "defaultAddress", string phoneNumber = "defaultPhoneNumber")
        {
            EmployeeID = employeeID;
            EmployeeType = employeeType;
            EmployeeName = employeeName;
            BirthDay = birthDay;
            Gender = gender;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
