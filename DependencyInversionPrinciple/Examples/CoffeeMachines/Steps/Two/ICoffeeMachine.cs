using DependencyInversionPrinciple.Examples.CoffeeMachines.Models;

namespace DependencyInversionPrinciple.Examples.CoffeeMachines.Steps.Two
{
    public interface ICoffeeMachine
    {
        CoffeeDrink BrewFilterCoffee();
    }
}
