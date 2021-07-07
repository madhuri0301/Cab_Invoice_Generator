using System;
using System.Collections.Generic;
using System.Text;

namespace Cab_Invoice_Generator
{
    /// <summary>
    /// Class To Set The Data For Perticular Ride
    /// </summary>
    public class Ride
    {
        //Variables
        public double distance;
        public int time;

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="time"></param>
        public Ride(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }

    }
}
