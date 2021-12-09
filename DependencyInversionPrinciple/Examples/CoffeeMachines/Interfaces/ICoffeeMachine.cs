using DependencyInversionPrinciple.Examples.CoffeeMachines.Enumerations;
using DependencyInversionPrinciple.Examples.CoffeeMachines.Models;

namespace DependencyInversionPrinciple.Examples.CoffeeMachines.Interfaces
{
    public interface ICoffeeMachine
    {
        void AddGroundCoffee(CoffeeSelection sel, GroundCoffee newCoffee);
    }
}
