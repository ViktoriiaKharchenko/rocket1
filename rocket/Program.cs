using System;
using System.Collections.Generic;
 
namespace rocket
{

    class Rocket  {
        const int length = 55760000;
        Engine engine;
        Tank tank;
        Cabin cabin;
        double time;
       public Rocket  (Engine engine,Tank tank, Cabin cabin)
        {
            this.engine = engine;
            this.tank = tank;
            this.cabin = cabin;
            time = Math.Round(length / (engine.Power*1000));
            check();
        }
        void check()
        {
            if (engine.FuelСonsumption *length / 1000 <= tank.Volume) { Console.WriteLine("Rocket can reach Mars within " + time + " hours");
                return;
            }
            Console.WriteLine("Unfortunately this rocket can't reach Mars. Try again");
        }
    }
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
        public Engine (double power, double fuelConsumption)
        {
            Power = power;
            FuelСonsumption = fuelConsumption; 
        }
    }
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
        public Tank (double volume)
        {
            Volume = volume;
        }
    }
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
        public Cabin (int seatNumber)
        { 
          
            SeatNumber = seatNumber;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            int iter;
            Engine engine;
            Tank tank;
            Cabin cabin;
            List<Engine> engines = new List<Engine>() { new Engine(59.2, 100), new Engine(70.3, 150), new Engine(43.8, 80) };
            List<Tank> tanks = new List<Tank>() { new Tank(5576000), new Tank(6310000), new Tank(4460800) };
            List<Cabin> cabins = new List<Cabin>() { new Cabin(2), new Cabin(3), new Cabin(4)};
            while (true)
            {
                while (true) 
                { 
                    Console.WriteLine("Choose type of engine :");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("engine " + (i + 1) + " :" + "power " + engines[i].Power + " Fuel Consumption " + engines[i].FuelСonsumption + "\n");
                    }
                    try { iter = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            engine = engines[iter - 1];
                            break;
                        }
                        catch (Exception) { Console.WriteLine("Wrong answer, please try again"); }
                    }
                    catch (Exception) { Console.WriteLine("Wrong answer, please try again"); }  
                }
                while (true)
                {
                    Console.WriteLine("\nChoose type of tank :");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("tank " + (i + 1) + " :" + "volume " + tanks[i].Volume + "\n");
                    }
                    try
                    {
                        iter = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            tank = tanks[iter - 1];
                            break;
                        }
                        catch (Exception) { Console.WriteLine("Wrong answer, please try again"); }
                    }
                    catch (Exception) { Console.WriteLine("Wrong answer, please try again"); }
                }
                while (true)
                {
                    Console.WriteLine("\nChoose type of cabin :");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("cabin " + (i + 1) + " :" + "seat number " + cabins[i].SeatNumber + "\n");
                    }
                    try
                    {
                        iter = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            cabin = cabins[iter - 1];
                            break;
                        }
                        catch (Exception) { Console.WriteLine("Wrong answer, please try again"); }
                    }
                    catch (Exception) { Console.WriteLine("Wrong answer, please try again"); }

                }
                Rocket rocket = new Rocket(engine, tank, cabin);
                Console.WriteLine("\nTry again? \n");
                response = Console.ReadLine();
                if (response.Contains("No") || response.Contains ("no") || response == "0") { break;}

            }

        }

    }
}
