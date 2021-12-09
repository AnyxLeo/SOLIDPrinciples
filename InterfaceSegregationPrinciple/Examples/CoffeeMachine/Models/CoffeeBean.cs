namespace InterfaceSegregationPrinciple.Examples.CoffeMachine.Models
{
    public class CoffeeBean : Coffee
    {
        public CoffeeBean(string name, int quantity)
        {
            Description = name;
            Quantity = quantity;
        }
    }
}