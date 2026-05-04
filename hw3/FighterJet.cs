using System;
using System.Collections.Generic;
using System.Text;

namespace assingment_3
{
    internal class FighterJet : Aircraft
    {
        public bool missilesLoaded;
        public FighterJet(string fligtNumber, int altitude, bool missilesLoaded) : base(fligtNumber, altitude)
        {
        }
        public override void PrintStatus()
        {
            base.PrintStatus();
            Console.WriteLine($"Missiles loaded: {missilesLoaded}");
        }

        public void FireMissile()
        {
            missilesLoaded = false;
            Console.WriteLine("Missile fired!");
        }
    }
}
