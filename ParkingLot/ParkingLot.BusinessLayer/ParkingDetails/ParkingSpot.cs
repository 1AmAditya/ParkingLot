using ParkingLot.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.BusinessLayer
{
    public abstract class ParkingSpot
    {
        public int ID { get; set; }
        public Vehicle Vehicle { get; set; }
        public bool free { get; set; }
        public ParkingSpotType parkingSpotType { get; set; }

        public ParkingSpot(ParkingSpotType parkingSpotType)
        {
            this.parkingSpotType = parkingSpotType;
        }

        public bool assignVehicle(Vehicle vehicle)
        {
            this.Vehicle = vehicle;
            this.free = false;
            return true;
        }

        public bool removeVehicle(Vehicle vehicle)
        {
            this.Vehicle = null;
            this.free = true;
            return true;
        }
    }

    public class HandicappedSpot : ParkingSpot
    {
        public HandicappedSpot() : base(ParkingSpotType.HANDICAPPED)
        {

        }
    }

    public class CompactSpot : ParkingSpot
    {
        public CompactSpot() : base(ParkingSpotType.COMPACT)
        {

        }
    }

    public class LargeSpot : ParkingSpot
    {
        public LargeSpot() : base(ParkingSpotType.LARGE)
        {

        }
    }

    public class MotorbikeSpot : ParkingSpot
    {
        public MotorbikeSpot() : base(ParkingSpotType.MOTORBIKE)
        {

        }
    }

    public class ElectricSpot : ParkingSpot
    {
        public ElectricSpot() : base(ParkingSpotType.ELECTRIC)
        {

        }
    }
}
