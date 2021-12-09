using LiskovSubstitutionPrinciple.Examples.CoffeMachine.Enumerations;
using LiskovSubstitutionPrinciple.Examples.CoffeMachine.Exeptions;
using LiskovSubstitutionPrinciple.Examples.CoffeMachine.Models;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple.Examples.CoffeMachine.Steps.One
{
    public class BasicCoffeeMachine
    {
        private Dictionary<CoffeeSelection, Configuration> _configMap;
        private Dictionary<CoffeeSelection, GroundCoffee> _groundCoffee;
        private BrewingUnit _brewingUnit;

        public BasicCoffeeMachine(Dictionary<CoffeeSelection, GroundCoffee> coffee)
        {
            _groundCoffee = coffee;
            _brewingUnit = new BrewingUnit();

            _configMap = new Dictionary<CoffeeSelection, Configuration>();
            _configMap[CoffeeSelection.FILTER_COFFEE] = new Configuration(30, 480);
        }

        public CoffeeDrink BrewCoffee(CoffeeSelection selection)
        {
            switch (selection)
            {
                case CoffeeSelection.FILTER_COFFEE:
                    return BrewFilterCoffee();
                default:
                    throw new CoffeeException(
                        "CoffeeSelection [" + selection + "] not supported!");
            }
        }

        private CoffeeDrink BrewFilterCoffee()
        {
            var config = _configMap[CoffeeSelection.FILTER_COFFEE];

            // grind the coffee beans 
            var groundCoffee = _groundCoffee[CoffeeSelection.FILTER_COFFEE];

            // brew an espresso 
            return _brewingUnit.brew(CoffeeSelection.FILTER_COFFEE, groundCoffee, config.QuantityWater);
        }

        public void AddGroundCoffee(CoffeeSelection sel, GroundCoffee newCoffee)
        {
            var existingCoffee = _groundCoffee[sel];
            if (existingCoffee != null)
            {
                if (existingCoffee.Description.Equals(newCoffee.Description))
                {
                    existingCoffee.Quantity += newCoffee.Quantity;
                }
                else
                {
                    throw new CoffeeException("Only one kind of coffee supported for each CoffeeSelection.");
                }
            }
            else
            {
                _groundCoffee[sel] = newCoffee;
            }
        }
    }
}
