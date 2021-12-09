using DependencyInversionPrinciple.Examples.CoffeeMachines.Enumerations;

namespace DependencyInversionPrinciple.Examples.CoffeeMachines.Models
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
