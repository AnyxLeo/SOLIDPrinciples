using InterfaceSegregationPrinciple.Examples.CoffeMachine.Enumerations;
using System;

namespace InterfaceSegregationPrinciple.Examples.CoffeMachine.Models
{ 
    public class BrewingUnit
    {

        public CoffeeDrink brew(CoffeeSelection selection, GroundCoffee groundCoffee,
                double quantity)
        {
            return new CoffeeDrink(selection, quantity);
        }
    }
}