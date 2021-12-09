namespace LiskovSubstitutionPrinciple.Examples.CoffeMachine.Models
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