using ParkingLot.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.BusinessLayer
{
    public class ParkingRate
    {
        public VehicleType VehicleType { get; set; }
        public Dictionary<int,double> VehiclePrice { get; set; }
    }
}
