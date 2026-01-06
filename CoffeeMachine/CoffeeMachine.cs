using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    internal class CoffeeMachine
    {
        int water = 0;
        int coffee = 0;
        int chocolate = 0;
        int milk = 0;

        // Constructor
        public CoffeeMachine(int water, int coffee, int chocolate, int milk)
        {
            this.water = water;
            this.coffee = coffee;
            this.chocolate = chocolate;
            this.milk = milk;
        }

        // Brew Black Coffee: Requires 300g water, 20g coffee
        public void BrewBlackCoffee()
        {
            if (this.water >= 300 && this.coffee >= 20)
            {
                this.water -= 300;
                this.coffee -= 20;
                Console.WriteLine("Brewing black coffee... Done!");
            }
            else
            {
                Console.WriteLine("Insufficient ingredients!");
            }
        }

        // Brew Mocha: Requires 300g water, 20g coffee, 10g chocolate
        public void BrewMocha()
        {
            if (this.water >= 300 && this.coffee >= 20 && this.chocolate >= 10)
            {
                this.water -= 300;
                this.coffee -= 20;
                this.chocolate -= 10;
                Console.WriteLine("Brewing mocha... Done!");
            }
            else
            {
                Console.WriteLine("Insufficient ingredients!");
            }
        }

        // Brew Latte: Requires 300g water, 20g coffee, 10g milk
        public void BrewLatte()
        {
            if (this.water >= 300 && this.coffee >= 20 && this.milk >= 10)
            {
                this.water -= 300;
                this.coffee -= 20;
                this.milk -= 10;
                Console.WriteLine("Brewing latte... Done!");
            }
            else
            {
                Console.WriteLine("Insufficient ingredients!");
            }
        }

        // Brew Chocolate: Requires 300g water, 20g chocolate
        public void BrewChocolate()
        {
            if (this.water >= 300 && this.chocolate >= 20)
            {
                this.water -= 300;
                this.chocolate -= 20;
                Console.WriteLine("Brewing chocolate... Done!");
            }
            else
            {
                Console.WriteLine("Insufficient ingredients!");
            }
        }

        // Show current stock
        public void ShowStock()
        {
            Console.WriteLine("Current stock:");
            Console.WriteLine("Water: " + this.water + "g");
            Console.WriteLine("Coffee: " + this.coffee + "g");
            Console.WriteLine("Chocolate: " + this.chocolate + "g");
            Console.WriteLine("Milk: " + this.milk + "g");
        }

        // Increment stock
        public void IncrementStock(int waterAmount, int coffeeAmount, int chocolateAmount, int milkAmount)
        {
            this.water += waterAmount;
            this.coffee += coffeeAmount;
            this.chocolate += chocolateAmount;
            this.milk += milkAmount;
            Console.WriteLine("Stock incremented.");
        }
    }
}
