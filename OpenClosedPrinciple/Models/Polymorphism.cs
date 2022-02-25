using OpenClosedPrinciple.Examples.CoffeeMachines.Enumerations;
using OpenClosedPrinciple.Examples.CoffeeMachines.Exceptions;
using OpenClosedPrinciple.Examples.CoffeeMachines.Models;
using OpenClosedPrinciple.Examples.CoffeeMachines.Steps.Two;
using OpenClosedPrinciple.Examples.Steps.Two;
using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple.Models
{
    public class Polymorphism
    {

        private void SetupCoffeeApp()
        {
            // create a Map of available coffee beans
            var beans = new Dictionary<CoffeeSelection, CoffeeBean>();
            beans[CoffeeSelection.FILTER_COFFEE] = new CoffeeBean("My favorite filter coffee bean", 1000);
            beans[CoffeeSelection.ESPRESSO] = new CoffeeBean("My favorite espresso bean", 1000);

            // get a new CoffeeMachine object
            var machine = new PremiumCoffeeMachine(beans);

            
            // Instantiate CoffeeApp
            var app = new CoffeeApp(machine);

            var beans1 = new Dictionary<CoffeeSelection, GroundCoffee>();
            beans1[CoffeeSelection.FILTER_COFFEE] = new GroundCoffee("My favorite filter coffee bean", 1000);
            var basicmachine = new BasicCoffeeMachine(beans1);
            var app1 = new CoffeeApp(basicmachine);

            // brew a fresh coffee
            try
            {
                app.PrepareCoffee(CoffeeSelection.FILTER_COFFEE);
                app1.PrepareCoffee(CoffeeSelection.FILTER_COFFEE);
            }
            catch (CoffeeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}