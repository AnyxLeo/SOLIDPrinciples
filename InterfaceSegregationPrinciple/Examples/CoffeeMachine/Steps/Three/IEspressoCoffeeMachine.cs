using InterfaceSegregationPrinciple.Examples.CoffeMachine.Models;

namespace InterfaceSegregationPrinciple.Examples.CoffeeMachine.Steps.Three
{
    public interface IEspressoCoffeeMachine : ICoffeeMachine
    {
        CoffeeDrink BrewEspresso();
    }
}
