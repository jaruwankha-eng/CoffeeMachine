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
            CoffeeMachine machine = new CoffeeMachine();
bool running = true;

while (running)
{
    Console.WriteLine("===== Coffee Machine =====");
    Console.WriteLine("1. Coffee");
    Console.WriteLine("2. Mocha");
    Console.WriteLine("3. Latte");
    Console.WriteLine("4. Chocolate");
    Console.WriteLine("5. Show Stock");
    Console.WriteLine("0. Exit");
    Console.Write("Select menu: ");

    string input = Console.ReadLine();
    Console.WriteLine();

    switch (input)
    {
        case "1":
            machine.MakeCoffee();
            break;
        case "2":
            machine.MakeMocha();
            break;
        case "3":
            machine.MakeLatte();
            break;
        case "4":
            machine.MakeChocolate();
            break;
        case "5":
            machine.ShowStock();
            break;
        case "0":
            running = false;
            Console.WriteLine("Exit program...");
            break;
        default:
            Console.WriteLine("Invalid menu!");
            break;
    }

    Console.WriteLine();
}
        }
    }
}
