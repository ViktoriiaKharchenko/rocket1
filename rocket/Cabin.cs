using System;
using System.Collections.Generic;
using System.Text;

namespace rocket
{
    class Cabin
    {
        int seatNumber;

        public int SeatNumber
        {
            get
            {
                return this.seatNumber;
            }
            private set { this.seatNumber = value; }
        }
        public Cabin(int seatNumber)
        {

            SeatNumber = seatNumber;
        }
    }
}
