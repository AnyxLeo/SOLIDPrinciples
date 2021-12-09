using LiskovSubstitutionPrinciple.Examples.CoffeMachine.Enumerations;
using LiskovSubstitutionPrinciple.Examples.CoffeMachine.Interfaces;
using LiskovSubstitutionPrinciple.Examples.CoffeMachine.Models;
using System;

namespace LiskovSubstitutionPrinciple.Examples.CoffeMachine.Steps.Two
{
    public class CoffeeApp
    {
        private ICoffeeMachine _coffeeMachine;

        public CoffeeApp(ICoffeeMachine coffeeMachine)
        {
            _coffeeMachine = coffeeMachine;
        }

        public CoffeeDrink PrepareCoffee(CoffeeSelection selection)
        {
            var coffee = _coffeeMachine.BrewCoffee(selection);
            Console.WriteLine("Coffee is ready!");

            return coffee;
        }
    }
}
