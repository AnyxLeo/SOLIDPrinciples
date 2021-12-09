using OpenClosedPrinciple.Examples.CoffeeMachines.Enumerations;
using OpenClosedPrinciple.Examples.CoffeeMachines.Models;
using System;

namespace OpenClosedPrinciple.Examples.CoffeeMachines.Steps.One
{
    public class BasicCoffeeApp
    {
        private BasicCoffeeMachine _coffeeMachine;

        public BasicCoffeeApp(BasicCoffeeMachine coffeeMachine)
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
