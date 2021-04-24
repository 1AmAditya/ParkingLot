using ParkingLot.BusinessLayer.Account1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.BusinessLayer
{
    public class ParkingLot
    {
        public EntrancePanel _entrancePanel;
        public ExitPanel _exitPanel;
        public ParkingFloor _parkingFloor;
        public ParkingLot(EntrancePanel entrancePanel, ExitPanel exitPanel, ParkingFloor parkingFloor)
        {
            _exitPanel = exitPanel;
            _entrancePanel = entrancePanel;
            _parkingFloor = parkingFloor;
        }
        public int ID { get; set; }
        public Address Address { get; set; }

        public bool AddFloor()
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

        public bool AddCustomerInfoPortal()
        {
            return true;
        }

        public bool AddParkingAttendentPortal()
        {
            return true;
        }
    }
}
