namespace DependencyInversionPrinciple.Examples.CoffeeMachines.Models
{
    public class Configuration
    {
        public int QuantityCoffee { get; set; }
        public int QuantityWater { get; set; }

        public Configuration(int coffee, int water)
        {
            QuantityCoffee = coffee;
            QuantityWater = water;
        }
    }
}