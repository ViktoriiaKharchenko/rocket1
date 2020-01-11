using System;
using System.Collections.Generic;
using System.Text;

namespace rocket
{
    class RocketLauncher
    {
        const int distance = 55760000;
        Rocket rocket;
        double time;
        public RocketLauncher(Rocket rocket)
        {
            this.rocket = rocket;
        }
        internal void check()
        {
            time = Math.Round(distance / (rocket.GetEngine().Power * 1000));
            if (rocket.GetEngine().FuelСonsumption * distance / 1000 <= rocket.GetTank().Volume)
            {
                Console.WriteLine("\nRocket can reach Mars within " + time + " hours");
                return;
            }
            Console.WriteLine("\nUnfortunately this rocket can't reach Mars. Try again");
        }

    }
}
