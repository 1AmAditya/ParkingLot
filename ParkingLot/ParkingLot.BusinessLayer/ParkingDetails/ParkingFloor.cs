using ParkingLot.BusinessLayer.Account1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.BusinessLayer
{
    public class ParkingFloor
    {
        public ParkingSpot _parkingSpot; 
        public ParkingFloor(ParkingSpot parkingSpot)
        {
            _parkingSpot = parkingSpot;
        }
        public int ID { get; set; }

        public bool AddCarSpot()
        {
            return true;
        }

        public bool AddExitPanel()
        {
            return true;
        }

        public bool AddEntrancePanel()
        {
            return true;
        }
    }
}
