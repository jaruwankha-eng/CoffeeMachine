using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create CoffeeMachine object with initial stock (e.g., 1000g for each ingredient)
            CoffeeMachine machine = new CoffeeMachine(1000, 1000, 1000, 1000);

            bool running = true;
            while (running)
            {
                // Menu interface
                Console.WriteLine("---------------------------");
                Console.WriteLine("Welcome to Coffee Machine");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1 : Brew Black Coffee");
                Console.WriteLine("2 : Brew Mocha");
                Console.WriteLine("3 : Brew Latte");
                Console.WriteLine("4 : Brew Chocolate");
                Console.WriteLine("5 : Show Stock");
                Console.WriteLine("6 : Increment Stock");
                Console.WriteLine("0 : Exit");
                Console.WriteLine("---------------------------");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        machine.BrewBlackCoffee();
                        break;
                    case "2":
                        machine.BrewMocha();
                        break;
                    case "3":
                        machine.BrewLatte();
                        break;
                    case "4":
                        machine.BrewChocolate();
                        break;
                    case "5":
                        machine.ShowStock();
                        break;
                    case "6":
                        // Prompt user for amounts to increment
                        Console.WriteLine("Enter water to add (g):");
                        int w = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter coffee to add (g):");
                        int c = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter chocolate to add (g):");
                        int ch = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter milk to add (g):");
                        int m = int.Parse(Console.ReadLine());
                        machine.IncrementStock(w, c, ch, m);
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input, try again");
                        break;
                
                }
            }
        }
    }
}
