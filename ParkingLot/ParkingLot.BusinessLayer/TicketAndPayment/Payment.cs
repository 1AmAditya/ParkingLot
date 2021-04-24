using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.BusinessLayer
{
    public class Payment
    {
        ParkingRate _parkingRate;
        public Payment(ParkingRate parkingRate)
        {
            _parkingRate = parkingRate;
        }
        public bool ProcessPayment(Ticket ticket)
        {
            return true;
        }
    }
}
