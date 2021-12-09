using DependencyInversionPrinciple.Examples.CoffeeMachines.Models;
using System;

namespace DependencyInversionPrinciple.Examples.CoffeeMachines.Steps.One
{
    public class CoffeeApp
    {
        private BasicCoffeeMachine _coffeeMachine;

        public CoffeeApp(BasicCoffeeMachine coffeeMachine)
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
