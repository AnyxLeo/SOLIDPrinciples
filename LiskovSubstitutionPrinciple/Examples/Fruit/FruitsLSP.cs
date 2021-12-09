using System;

/// <summary>
/// Several classes are here only for demonstration purposes.
/// It is a best practice that each class has its own file.
/// </summary>
namespace LiskovSubstitutionPrinciple.Examples.Fruit
{
    public class FruitsLSP
    {
        public static void Main(string[] args)
        {
            Fruit fruit = new Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple();
            Console.WriteLine(fruit.GetColor());
        }
    }

    public abstract class Fruit
    {
        public abstract string GetColor();
    }
    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
