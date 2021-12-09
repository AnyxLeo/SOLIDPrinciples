using InterfaceSegregationPrinciple.Examples.CoffeMachine.Models;

namespace InterfaceSegregationPrinciple.Examples.CoffeeMachine.Steps.Three
{
    public interface ICoffeeMachine
    {
        void AddGroundCoffee(GroundCoffee newCoffee);
    }
}
