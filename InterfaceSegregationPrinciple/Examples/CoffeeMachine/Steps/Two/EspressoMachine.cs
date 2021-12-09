using InterfaceSegregationPrinciple.Examples.CoffeMachine.Enumerations;
using InterfaceSegregationPrinciple.Examples.CoffeMachine.Exeptions;
using InterfaceSegregationPrinciple.Examples.CoffeMachine.Models;
using System.Collections.Generic;

namespace InterfaceSegregationPrinciple.Examples.CoffeeMachine.Steps.Two
{
    public class EspressoMachine : ICoffeeMachine
    {
        private Dictionary<CoffeeSelection, Configuration> _configMap;
        private GroundCoffee _groundCoffee;
        private BrewingUnit _brewingUnit;

        public EspressoMachine(GroundCoffee coffee)
        {
            _groundCoffee = coffee;
            _brewingUnit = new BrewingUnit();

            _configMap = new Dictionary<CoffeeSelection, Configuration>();
            _configMap[CoffeeSelection.ESPRESSO] = new Configuration(8, 28);
        }

        public CoffeeDrink BrewEspresso()
        {
            var config = _configMap[CoffeeSelection.ESPRESSO];

            // brew a filter coffee
            return _brewingUnit.brew(CoffeeSelection.ESPRESSO,
                _groundCoffee, config.QuantityWater);
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
                    throw new CoffeeException(
                        "Only one kind of coffee supported for each CoffeeSelection.");
                }
            }
            else
            {
                _groundCoffee = newCoffee;
            }
        }

        // step 2
        public CoffeeDrink BrewFilterCoffee()
        {
            throw new CoffeeException("This machine only brew espresso.");
        }
    }
}
