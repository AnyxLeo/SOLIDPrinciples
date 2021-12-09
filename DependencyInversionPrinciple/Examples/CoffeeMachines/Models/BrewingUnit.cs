using DependencyInversionPrinciple.Examples.CoffeeMachines.Enumerations;

namespace DependencyInversionPrinciple.Examples.CoffeeMachines.Models
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