using System;

/// <summary>
/// Several classes are here only for demonstration purposes.
/// It is a best practice that each class has its own file.
/// </summary>
namespace OpenClosedPrinciple.Examples.Shapes
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }

    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return (Base * Height)/2;
        }
    }
}
