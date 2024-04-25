using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Vehicle
    {
        public string VehicleID { get; set; }
        public string LicensePlate { get; set; }
        public int Occupancy { get; set; }
        public string TypeOfVehicle { get; set; }
        public string CustomerID { get; set; }
        public string ParkingSpotID { get; set; }

        public Vehicle(string vehicleID = "defaultID", string licensePlate = "defaultLicensePlate", int occupancy = 0, string typeOfVehicle = "defaultType", string customerID = "defaultCustomerID", string parkingSpotID = "defaultParkingSpotID")
        {
            VehicleID = vehicleID;
            LicensePlate = licensePlate;
            Occupancy = occupancy;
            TypeOfVehicle = typeOfVehicle;
            CustomerID = customerID;
            ParkingSpotID = parkingSpotID;
        }
    }
}
