using System;
using System.Collections.Generic;
using System.Text;

namespace rocket
{
    class RocketBuilder
    {
        string response;
        int iter;
        Engine engine;
        Tank tank;
        Cabin cabin;
        List<Engine> engines = new List<Engine>() { new Engine(59.2, 100), new Engine(70.3, 150), new Engine(43.8, 80) };
        List<Tank> tanks = new List<Tank>() { new Tank(5576000), new Tank(6310000), new Tank(4460800) };
        List<Cabin> cabins = new List<Cabin>() { new Cabin(2), new Cabin(3), new Cabin(4) };
        Rocket rocket;
        RocketLauncher launcher;
        void ChooseEngine()
        {
            while (true)
            {
                Console.WriteLine("Choose type of engine :");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("engine " + (i + 1) + " :" + "power " + engines[i].Power + " Fuel Consumption " + engines[i].FuelСonsumption + "\n");
                }
                try
                {
                    iter = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        engine = engines[iter - 1];
                        break;
                    }
                    catch (Exception) { Console.WriteLine("\nWrong answer, please try again\n"); }
                }
                catch (Exception) { Console.WriteLine("\nWrong answer, please try again\n"); }
            }
            Console.Clear();
        }
        void ChooseTank()
        {
            while (true)
            {
                Console.WriteLine("Choose type of tank :");
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
                    catch (Exception) { Console.WriteLine("\nWrong answer, please try again\n"); }
                }
                catch (Exception) { Console.WriteLine("\nWrong answer, please try again\n"); }
            }
            Console.Clear();
        }
        void ChooseCabin()
        {
            while (true)
            {
                Console.WriteLine("Choose type of cabin :");
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
                    catch (Exception) { Console.WriteLine("\nWrong answer, please try again\n"); }
                }
                catch (Exception) { Console.WriteLine("\nWrong answer, please try again\n"); }

            }
            Console.Clear();
        }
        public void Run()
        {
            while (true)
            {
                ChooseEngine();
                ChooseTank();
                ChooseCabin();
                rocket = new Rocket(engine, tank, cabin);
                launcher = new RocketLauncher(rocket);
                launcher.check();
                Console.WriteLine("\nTry again? \n Yes - 1 \t No - 0");
                response = Console.ReadLine();
                if (response.Contains("No") || response.Contains("no") || response == "0") { break; }
                Console.Clear();
            }

        }
    }
}
