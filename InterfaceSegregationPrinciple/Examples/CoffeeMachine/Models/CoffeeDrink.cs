using InterfaceSegregationPrinciple.Examples.CoffeMachine.Enumerations;

namespace InterfaceSegregationPrinciple.Examples.CoffeMachine.Models
{
	public class CoffeeDrink
	{
		public CoffeeSelection Selection { get; set; }

		public double Quantity { get; set; }

		public CoffeeDrink(CoffeeSelection selection, double quantity)
		{
			Selection = selection;
			Quantity = quantity;
		}
	}
}
