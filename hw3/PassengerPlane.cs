using System;
using System.Collections.Generic;
using System.Text;

namespace assingment_3
{
    internal class PassengerPlane: Aircraft
    {
        int passengersCount;
        public PassengerPlane(string flightNumber, int altitude, int passengersCount) : base(flightNumber, altitude)
        {
            this.passengersCount = passengersCount;
        }
        public override void PrintStatus()
        {
            base.PrintStatus();
            Console.WriteLine($"Number of passengers: {passengersCount}");
        }
    
    }
}
