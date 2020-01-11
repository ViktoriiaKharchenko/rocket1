using System;
using System.Collections.Generic;
using System.Text;

namespace rocket
{
    class Engine
    {
        double power;
        double fuelConsumption;
        public double Power
        {
            get
            {
                return this.power;
            }
            private set { this.power = value; }

        }
        public double FuelСonsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            private set { this.fuelConsumption = value; }
        }
        public Engine(double power, double fuelConsumption)
        {
            Power = power;
            FuelСonsumption = fuelConsumption;
        }

    }
}
