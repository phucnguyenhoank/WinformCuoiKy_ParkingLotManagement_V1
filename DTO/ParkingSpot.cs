using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ParkingSpot
    {
        public string ParkingSpotID { get; set; }
        public int BeingOccupied { get; set; }
        public string DesignatedFor { get; set; }
        public int Capacity { get; set; }

        public ParkingSpot(string parkingSpotID = "defaultID", int beingOccupied = 0, string designatedFor = "defaultDesignation", int capacity = 0)
        {
            ParkingSpotID = parkingSpotID;
            BeingOccupied = beingOccupied;
            DesignatedFor = designatedFor;
            Capacity = capacity;
        }
    }
}
