using System;
using System.Collections.Generic;
using System.Text;

namespace assingment_3
{
    internal class Aircraft
    {
        string flightNumber;
        int altitude;

        public  Aircraft(string flightNumber, int altitude)
        {
            this.flightNumber = flightNumber;
            this.altitude = altitude;
        }
        public virtual void PrintStatus()
        {
            Console.WriteLine($"Flight number: {flightNumber}, Altitude: {altitude}");
        }
    }
}
