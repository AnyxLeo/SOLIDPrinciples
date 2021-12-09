using DependencyInversionPrinciple.Examples.CoffeeMachines.Models;

namespace DependencyInversionPrinciple.Examples.CoffeeMachines.Steps.Two
{
    public interface IEspressoMachine
    {
        CoffeeDrink BrewEspresso();
    }
}
