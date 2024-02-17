using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_3
{
    internal class Program
    {
       static Pokemon Spawn()
        {
            Random rnd = new Random();

            int level = rnd.Next(0, 21);

            int type = rnd.Next(0, 4);

            switch (type)
            {
                case 1:
                    return new Bulbasaur(level);
                case 2:
                    return new Charmander(level);
                default:
                    return new Caterpie(level);
            }
        }

       static float throwBall()
        {
            float ballMultiplier = 0;
            float berryMultiplier = 1;
            float curveMultiplier = 1;

            Console.WriteLine("Select a ball [Poke, Great, Ultra]");
            string type = Console.ReadLine().ToLower();

            switch (type)
            {
                case "poke":
                    ballMultiplier = 1;
                    break;
                case "great":
                    ballMultiplier = 1.5f;
                    break;
                case "ultra":
                    ballMultiplier = 2;
                    break;
                default:
                    Console.WriteLine("Poke ball used by default");
                    ballMultiplier = 1;
                    break;
            }

            Console.WriteLine("Select a berry [None, Razz, SilverPinap, GoldenRazz]");
            string berry = Console.ReadLine().ToLower();

            switch (berry)
            {
                case "razz":
                    berryMultiplier = 1.5f;
                    break;
                case "silverpinap":
                    berryMultiplier = 1.8f;
                    break;
                case "goldenrazz":
                    berryMultiplier = 2.5f;
                    break;
                default:
                    berryMultiplier = 1;
                    break;
            }

            Console.WriteLine("Is it a curveball? (Yes/No)");
            string isCurve = Console.ReadLine().ToLower();

            if (isCurve == "yes")
            {
                curveMultiplier = 1.7f;
            }

            return ballMultiplier * berryMultiplier * curveMultiplier;
        }
        

        
        static void Main(string[] args)
        {
            Pokedex myDex = new Pokedex();
            Random rnd = new Random();
            float cpm = 0.49985844f;
            bool quit = false;

            do
            {
                Pokemon encounter = Spawn();
                while (true)
                {
                    float catchProb = 1 - (float)Math.Pow((1 - encounter.getBaseCatchRate() / 2 * cpm), throwBall());
                    float randNum = (float)rnd.NextDouble();

                    if (randNum < catchProb)
                    {
                        Console.WriteLine(encounter.ToString() + " caught.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Oops " + encounter.ToString() + " jumped out, try again!");
                    }
                }
                Console.WriteLine("Do you want to continue catching Pokemon?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "no")
                {
                    quit = true;
                    break;
                }
            }
            while (!quit);
        }
    }
}
