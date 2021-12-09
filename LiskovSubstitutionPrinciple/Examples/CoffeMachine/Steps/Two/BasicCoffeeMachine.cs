using LiskovSubstitutionPrinciple.Examples.CoffeMachine.Enumerations;
using LiskovSubstitutionPrinciple.Examples.CoffeMachine.Exeptions;
using LiskovSubstitutionPrinciple.Examples.CoffeMachine.Interfaces;
using LiskovSubstitutionPrinciple.Examples.CoffeMachine.Models;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple.Examples.CoffeMachine.Steps.Two
{
    public class BasicCoffeeMachine : ICoffeeMachine //Adapting the BasicCoffeeMachine 
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
            var config = _configMap[selection];

            // get the coffee
            var groundCoffee = _groundCoffee[selection];

            // brew a filter coffee
            return _brewingUnit.brew(selection, groundCoffee, config.QuantityWater);
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
