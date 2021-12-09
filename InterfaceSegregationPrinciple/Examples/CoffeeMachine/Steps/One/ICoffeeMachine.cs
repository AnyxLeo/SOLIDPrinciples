using InterfaceSegregationPrinciple.Examples.CoffeMachine.Models;

namespace InterfaceSegregationPrinciple.Examples.CoffeMachine.Step.One
{
    public interface ICoffeeMachine
    {
        CoffeeDrink BrewFilterCoffee();
        void AddGroundCoffee(GroundCoffee newCoffee);
    }
}
