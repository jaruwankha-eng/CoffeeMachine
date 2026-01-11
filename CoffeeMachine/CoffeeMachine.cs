using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    internal class CoffeeMachine
    {
        private int water = 2000;
        private int coffee = 500;
        private int milk = 300;
        private int chocolate = 300;

        public void MakeCoffee()
        {
            if (water >= 300 && coffee >= 20)
            {
                water -= 300;
                coffee -= 20;
                Console.WriteLine("Coffee is ready ☕");
            }
            else
            {
                Console.WriteLine("Not enough ingredients!");
            }
        }

        public void MakeMocha()
        {
            if (water >= 300 && coffee >= 20 && chocolate >= 10)
            {
                water -= 300;
                coffee -= 20;
                chocolate -= 10;
                Console.WriteLine("Mocha is ready ☕");
            }
            else
            {
                Console.WriteLine("Not enough ingredients!");
            }
        }

        public void MakeLatte()
        {
            if (water >= 300 && coffee >= 20 && milk >= 10)
            {
                water -= 300;
                coffee -= 20;
                milk -= 10;
                Console.WriteLine("Latte is ready ☕");
            }
            else
            {
                Console.WriteLine("Not enough ingredients!");
            }
        }

        public void MakeChocolate()
        {
            if (water >= 300 && chocolate >= 20)
            {
                water -= 300;
                chocolate -= 20;
                Console.WriteLine("Chocolate is ready ☕");
            }
            else
            {
                Console.WriteLine("Not enough ingredients!");
            }
        }

        public void ShowStock()
        {
            Console.WriteLine("=== Current Stock ===");
            Console.WriteLine($"Water: {water}");
            Console.WriteLine($"Coffee: {coffee}");
            Console.WriteLine($"Milk: {milk}");
            Console.WriteLine($"Chocolate: {chocolate}");
        }
    }
}
