using LiskovSubstitutionPrinciple.Examples.CoffeMachine.Enumerations;
using System;

namespace LiskovSubstitutionPrinciple.Examples.CoffeMachine.Models
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