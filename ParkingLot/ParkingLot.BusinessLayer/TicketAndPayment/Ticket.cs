using ParkingLot.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.BusinessLayer
{
    public class Ticket
    {
        public string VehicleNo { get; set; }
        public VehicleType VehicleType { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public double Amount { get; set; }
        public ParkingTicketStatus Status { get; set; }
    }
}
