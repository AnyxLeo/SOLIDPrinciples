using DependencyInversionPrinciple.Examples.CoffeeMachines.Enumerations;
using DependencyInversionPrinciple.Examples.CoffeeMachines.Exeptions;
using DependencyInversionPrinciple.Examples.CoffeeMachines.Models;
using System.Collections.Generic;

namespace DependencyInversionPrinciple.Examples.CoffeeMachines.Steps.One
{
    public class BasicCoffeeMachine
    {
        private Configuration _config;
        private Dictionary<CoffeeSelection, GroundCoffee> _groundCoffee;
        private BrewingUnit _brewingUnit;

        public BasicCoffeeMachine(Dictionary<CoffeeSelection, GroundCoffee> coffee)
        { 
            _groundCoffee = coffee;
            _brewingUnit = new BrewingUnit();
            _config = new Configuration(30, 480);
        }

        public CoffeeDrink BrewFilterCoffee()
        {
            // get the coffee
            var groundCoffee = _groundCoffee[CoffeeSelection.FILTER_COFFEE];
            // brew a filter coffee  
            return _brewingUnit.brew(CoffeeSelection.FILTER_COFFEE, groundCoffee, _config.QuantityWater);
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
