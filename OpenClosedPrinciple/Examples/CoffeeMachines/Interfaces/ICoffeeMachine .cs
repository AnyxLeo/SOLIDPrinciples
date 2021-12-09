using OpenClosedPrinciple.Examples.CoffeeMachines.Enumerations;
using OpenClosedPrinciple.Examples.CoffeeMachines.Models;

namespace OpenClosedPrinciple.Examples.CoffeeMachines.Interfaces
{
    public interface ICoffeeMachine
    {
        Coffee BrewCoffee(CoffeeSelection selection);
    }
}
