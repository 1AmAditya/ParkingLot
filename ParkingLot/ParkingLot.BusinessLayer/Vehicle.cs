using ParkingLot.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.BusinessLayer
{
    public class Vehicle
    {
        public string LicenseNo { get; set; }
        public readonly VehicleType VehicleType;

        public Ticket Ticket { get; set; }

        public Vehicle(VehicleType vehicleType)
        {
            VehicleType = vehicleType;
        }


    }

    public class Car : Vehicle
    {
        public Car() : base(VehicleType.CAR )
        {

        }
    }

    public class ELECTRIC : Vehicle
    {
        public ELECTRIC() : base(VehicleType.ELECTRIC)
        {

        }
    }

    public class MOTORBIKE : Vehicle
    {
        public MOTORBIKE() : base(VehicleType.MOTORBIKE)
        {

        }
    }

    public class TRUCK : Vehicle
    {
        public TRUCK() : base(VehicleType.TRUCK)
        {

        }
    }
     
}
