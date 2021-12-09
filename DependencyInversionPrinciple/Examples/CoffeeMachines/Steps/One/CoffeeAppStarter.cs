using DependencyInversionPrinciple.Examples.CoffeeMachines.Enumerations;
using DependencyInversionPrinciple.Examples.CoffeeMachines.Exeptions;
using DependencyInversionPrinciple.Examples.CoffeeMachines.Models;
using DependencyInversionPrinciple.Examples.CoffeeMachines.Steps.One;
using System;
using System.Collections.Generic;

namespace DependencyInversionPrinciple.Examples.CoffeeMachines.Steps.one

{
    public class CoffeeAppStarter
    {
        public static void main(String[] args)
        {
            var grounds = new Dictionary<CoffeeSelection, GroundCoffee>();
            grounds[CoffeeSelection.ESPRESSO] = new GroundCoffee("My favorite Cordoba grounds", 1000);

            var basicMachine = new BasicCoffeeMachine(grounds);
            // Instantiate CoffeeApp
            var app = new CoffeeApp(basicMachine);

            // create a Map of available coffee beans
            var beans = new Dictionary<CoffeeSelection, CoffeeBean>();
            beans[CoffeeSelection.ESPRESSO] = new CoffeeBean("My favorite espresso bean", 1000);
            beans[CoffeeSelection.FILTER_COFFEE] = new CoffeeBean("My favorite filter coffee bean", 1000);

            // get a new CoffeeMachine object
            var premiumCoffeeMachine = new PremiumCoffeeMachine(beans);

            var app1 = new CoffeeApp(premiumCoffeeMachine);
            // brew a fresh coffee
            try
            {
                app.PrepareCoffee();
                app1.PrepareCoffee();
            }
            catch (CoffeeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
