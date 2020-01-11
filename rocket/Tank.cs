using System;
using System.Collections.Generic;
using System.Text;

namespace rocket
{
    class Tank
    {
        double volume;
        public double Volume
        {
            get
            {
                return this.volume;
            }
            private set { this.volume = value; }
        }
        public Tank(double volume)
        {
            Volume = volume;
        }
    }
}
