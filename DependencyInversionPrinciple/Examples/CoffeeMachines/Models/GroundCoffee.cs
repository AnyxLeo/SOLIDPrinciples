namespace DependencyInversionPrinciple.Examples.CoffeeMachines.Models
{
    public class GroundCoffee : Coffee
    {
        public GroundCoffee(string name, int quantity)
        {
            Description = name;
            Quantity = quantity;
        }
      
    }
}