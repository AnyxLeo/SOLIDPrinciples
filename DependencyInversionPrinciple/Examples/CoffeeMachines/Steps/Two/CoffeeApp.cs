using DependencyInversionPrinciple.Examples.CoffeeMachines.Models;
using System;

namespace DependencyInversionPrinciple.Examples.CoffeeMachines.Steps.Two
{
    public class CoffeeApp
    {
        private ICoffeeMachine _coffeeMachine;

        public CoffeeApp(ICoffeeMachine coffeeMachine)
        {
            _coffeeMachine = coffeeMachine;
        }

        public CoffeeDrink PrepareCoffee()
        {
            var coffee = _coffeeMachine.BrewFilterCoffee();
            Console.WriteLine("Coffee is ready!");
            return coffee;
        }
    }
}
