using InterfaceSegregationPrinciple.Examples.CoffeMachine.Models;

namespace InterfaceSegregationPrinciple.Examples.CoffeeMachine.Steps.Three
{
    public interface IFilterCoffeeMachine : ICoffeeMachine
    {
        CoffeeDrink BrewFilterCoffee();
    }
}
