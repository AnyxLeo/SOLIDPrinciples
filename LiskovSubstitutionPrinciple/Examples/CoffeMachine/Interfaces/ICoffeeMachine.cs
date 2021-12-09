using LiskovSubstitutionPrinciple.Examples.CoffeMachine.Enumerations;
using LiskovSubstitutionPrinciple.Examples.CoffeMachine.Models;

namespace LiskovSubstitutionPrinciple.Examples.CoffeMachine.Interfaces
{
    public interface ICoffeeMachine
    {
        CoffeeDrink BrewCoffee(CoffeeSelection selection);
    }
}
