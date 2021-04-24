using ParkingLot.BusinessLayer.Account;
using ParkingLot.BusinessLayer.Account1;
using ParkingLot.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.BusinessLayer
{
    public abstract class Account
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public AccountStatus Status { get; set; }

        public Person Person { get; set; }
    }
}
