using DependencyInversionPrinciple.Examples.CoffeeMachines.Enumerations;
using DependencyInversionPrinciple.Examples.CoffeeMachines.Exeptions;
using DependencyInversionPrinciple.Examples.CoffeeMachines.Models;
using System.Collections.Generic;

namespace DependencyInversionPrinciple.Examples.CoffeeMachines.Steps.Two
{
    public class PremiumCoffeeMachine : ICoffeeMachine, IEspressoMachine
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

        public CoffeeDrink BrewEspresso()
        {
            var config = _configMap[CoffeeSelection.ESPRESSO];
            // grind the coffee beans
            var groundCoffee = _grinder.grind(_beans[CoffeeSelection.ESPRESSO], config.QuantityCoffee);

            // brew an espresso
            return _brewingUnit.brew(CoffeeSelection.ESPRESSO, groundCoffee, config.QuantityWater);
        }

        public CoffeeDrink BrewFilterCoffee()
        {
            var config = _configMap[CoffeeSelection.FILTER_COFFEE];
            // grind the coffee beans
            var groundCoffee = _grinder.grind(_beans[CoffeeSelection.FILTER_COFFEE], config.QuantityCoffee);
            // brew a filter coffee
            return _brewingUnit.brew(CoffeeSelection.FILTER_COFFEE, groundCoffee, config.QuantityWater);
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
                    throw new CoffeeException("Only one kind of coffee supported for each CoffeeSelection.");
                }
            }
            else
            {
                _beans[sel] = newBeans;
            }
        }
    }
}
