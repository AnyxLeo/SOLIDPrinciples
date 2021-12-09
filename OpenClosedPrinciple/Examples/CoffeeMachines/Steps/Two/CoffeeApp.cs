using OpenClosedPrinciple.Examples.CoffeeMachines.Enumerations;
using OpenClosedPrinciple.Examples.CoffeeMachines.Interfaces;
using OpenClosedPrinciple.Examples.CoffeeMachines.Models;
using System;

namespace OpenClosedPrinciple.Examples.Steps.Two
{
    public class CoffeeApp
    {
        private ICoffeeMachine _coffeeMachine;

        public CoffeeApp(ICoffeeMachine coffeeMachine)
        {
            _coffeeMachine = coffeeMachine;
        }

        public Coffee PrepareCoffee(CoffeeSelection selection)
        {
            var coffee = _coffeeMachine.BrewCoffee(selection);
            Console.WriteLine("Coffee is ready!");

            return coffee;
        }
    }
}
