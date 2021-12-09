using InterfaceSegregationPrinciple.Examples.CoffeMachine.Models;

namespace InterfaceSegregationPrinciple.Examples.CoffeeMachine.Steps.Two
{
    public interface ICoffeeMachine
    {
        CoffeeDrink BrewFilterCoffee();
        void AddGroundCoffee(GroundCoffee newCoffee);

        //step 2
        CoffeeDrink BrewEspresso();
    }
}
