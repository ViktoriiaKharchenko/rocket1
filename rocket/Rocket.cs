using System;
using System.Collections.Generic;
using System.Text;

namespace rocket
{
    class Rocket
    {

        Engine engine;
        Tank tank;
        Cabin cabin;

        public Rocket(Engine engine, Tank tank, Cabin cabin)
        {
            this.engine = engine;
            this.tank = tank;
            this.cabin = cabin;
        }
        public Engine GetEngine()
        {
            return engine;
        }
        public Tank GetTank()
        {
            return tank;
        }
        public Cabin GetCabin()
        {
            return cabin;
        }

    }
}
