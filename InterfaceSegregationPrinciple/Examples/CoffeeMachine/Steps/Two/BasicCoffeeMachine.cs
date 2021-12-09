using InterfaceSegregationPrinciple.Examples.CoffeMachine.Enumerations;
using InterfaceSegregationPrinciple.Examples.CoffeMachine.Exeptions;
using InterfaceSegregationPrinciple.Examples.CoffeMachine.Models;
using System.Collections.Generic;

namespace InterfaceSegregationPrinciple.Examples.CoffeeMachine.Steps.Two
{
    public class BasicCoffeeMachine : ICoffeeMachine
    {
        private Dictionary<CoffeeSelection, Configuration> _configMap;
        private GroundCoffee _groundCoffee;
        private BrewingUnit _brewingUnit;

        public BasicCoffeeMachine(GroundCoffee coffee)
        {
            _groundCoffee = coffee;
            _brewingUnit = new BrewingUnit();

            _configMap = new Dictionary<CoffeeSelection, Configuration>();
            _configMap[CoffeeSelection.FILTER_COFFEE] = new Configuration(30, 480);
        }

        public CoffeeDrink BrewFilterCoffee()
        {
            var config = _configMap[CoffeeSelection.FILTER_COFFEE];

            // brew an espresso 
            return _brewingUnit.brew(CoffeeSelection.FILTER_COFFEE, _groundCoffee, config.QuantityWater);
        }

        public void AddGroundCoffee(GroundCoffee newCoffee)
        {
            if (_groundCoffee != null)
            {
                if (_groundCoffee.Description.Equals(newCoffee.Description))
                {
                    _groundCoffee.Quantity += newCoffee.Quantity;
                }
                else
                {
                    throw new CoffeeException("Only one kind of coffee supported for each CoffeeSelection.");
                }
            }
            else
            {
                _groundCoffee = newCoffee;
            }
        }

        // step 2
        public CoffeeDrink BrewEspresso()
        {
            throw new CoffeeException("This machine only brews filter coffee.");
        }
    }
}
