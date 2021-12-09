using OpenClosedPrinciple.Examples.CoffeeMachines.Enumerations;
using OpenClosedPrinciple.Examples.CoffeeMachines.Exceptions;
using OpenClosedPrinciple.Examples.CoffeeMachines.Interfaces;
using OpenClosedPrinciple.Examples.CoffeeMachines.Models;
using System.Collections.Generic;

namespace OpenClosedPrinciple.Examples.Steps.Two
{
    public class PremiumCoffeeMachine : ICoffeeMachine
    {
        private Dictionary<CoffeeSelection, Configuration> _configMap;
        private Dictionary<CoffeeSelection, CoffeeBean> _beans;
        private Grinder _grinder;
        private BrewingUnit _brewingUnit;

        public PremiumCoffeeMachine(Dictionary<CoffeeSelection, CoffeeBean> beans)
        {
            _beans = beans;
            _grinder = new Grinder();
            _brewingUnit = new BrewingUnit();

            _configMap = new Dictionary<CoffeeSelection, Configuration>();
            _configMap[CoffeeSelection.ESPRESSO] = new Configuration(8, 28);
            _configMap[CoffeeSelection.FILTER_COFFEE] = new Configuration(30, 480);
        }

        public Coffee BrewCoffee(CoffeeSelection selection)
        {
            switch (selection)
            {
                case CoffeeSelection.ESPRESSO:
                    return BrewEspresso();
                case CoffeeSelection.FILTER_COFFEE:
                    return BrewFilterCoffee();
                default:
                    throw new CoffeeException($"CoffeeSelection [{selection}] not supported!");
            }
        }

        private Coffee BrewEspresso()
        {
            Configuration config = _configMap[CoffeeSelection.ESPRESSO];

            // grind the coffee beans 
            var groundCoffee = _grinder.grind(
                _beans[CoffeeSelection.ESPRESSO], config.QuantityCoffee);

            // brew an espresso 
            return _brewingUnit.brew(
                CoffeeSelection.ESPRESSO, groundCoffee, config.QuantityWater);
        }

        private Coffee BrewFilterCoffee()
        {
            var config = _configMap[CoffeeSelection.FILTER_COFFEE];

            // grind the coffee beans 
            var groundCoffee = _grinder.grind(
                _beans[CoffeeSelection.FILTER_COFFEE], config.QuantityCoffee);

            // brew an espresso 
            return _brewingUnit.brew(
                CoffeeSelection.FILTER_COFFEE, groundCoffee, config.QuantityWater);
        }

        public void AddCoffeeBeans(CoffeeSelection sel, CoffeeBean newBeans)
        {
            var existingBeans = _beans[sel];
            if (existingBeans != null)
            {
                if (existingBeans.Description.Equals(newBeans.Description))
                {
                    existingBeans.Quantity += newBeans.Quantity;
                }
                else
                {
                    throw new CoffeeException(
                        "Only one kind of beans supported for each CoffeeSelection.");
                }
            }
            else
            {
                _beans[sel] = newBeans;
            }
        }
    }
}
