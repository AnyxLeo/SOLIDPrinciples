using DependencyInversionPrinciple.Examples.CoffeeMachines.Enumerations;
using DependencyInversionPrinciple.Examples.CoffeeMachines.Exeptions;
using DependencyInversionPrinciple.Examples.CoffeeMachines.Models;
using System;
using System.Collections.Generic;

namespace DependencyInversionPrinciple.Examples.CoffeeMachines.Steps.Two
{
    public class CoffeeAppStarter
    {
        public static void main(String[] args)
        {
            // create a Map of available coffee beans
            var beans = new Dictionary<CoffeeSelection, CoffeeBean>();
            beans[CoffeeSelection.ESPRESSO] = new CoffeeBean("My favorite espresso bean", 1000);
            beans[CoffeeSelection.FILTER_COFFEE] = new CoffeeBean("My favorite filter coffee bean", 1000);

            var grounds = new Dictionary<CoffeeSelection, GroundCoffee>();
            grounds[CoffeeSelection.ESPRESSO] = new GroundCoffee("My favorite Cordoba grounds", 1000);
            // get a new CoffeeMachine object
            var machine = new PremiumCoffeeMachine(beans);

            var machine1 = new BasicCoffeeMachine(grounds);
            // Instantiate CoffeeApp
            var app = new CoffeeApp(machine);
            var app1 = new CoffeeApp(machine1);
            // brew a fresh coffee
            try
            {
                app.PrepareCoffee();
            }
            catch (CoffeeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
