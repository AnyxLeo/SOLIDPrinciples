
using OpenClosedPrinciple.Examples.CoffeeMachines.Enumerations;
using OpenClosedPrinciple.Examples.CoffeeMachines.Exceptions;
using OpenClosedPrinciple.Examples.CoffeeMachines.Models;
using OpenClosedPrinciple.Examples.CoffeeMachines.Steps.One;
using OpenClosedPrinciple.Examples.Shapes;
using OpenClosedPrinciple.Examples.Steps.Two;
using SOLID.Models;
using System;
using System.Collections.Generic;

/// <summary>
/// Open-closed principle
/// </summary>
/// <image url="$(SolutionDir)Assets\SOLID\open-closed.PNG" scale="1" /> 
namespace OpenClosedPrinciple.Models
{
    /// <summary>
    /// “Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification.”
    /// </summary>
    public class OpenClosedPrinciple
    {
        private Polymorphism _polymorphic;
        public OpenClosedPrinciple()
        {
            var author = new Person("Bertrand", "Meyer", " ", "");

            author.Greets();
            /// <summary>
            /// Object-Oriented Software Construction is a book by Bertrand Meyer, widely considered a foundational text of object-oriented programming
            /// </summary>
            ///<param name="publicationsList">
            /// 1988. Object-Oriented Software Construction.
            /// </summary>
            /// <image url="$(SolutionDir)Assets\SOLID\OCP.PNG" scale="0.5" /> 

            /// <summary>
            /// "A class is closed, since it may be compiled, stored in a library, baseline, and used by client classes.
            /// But it is also open, since any new class may use it as parent, adding new features. 
            /// When a descendant class is defined, there is no need to change the original or to disturb its clients.”
            /// </summary>
            Console.ReadLine();


            //Area Calculator
            var shapes = Shapes();
            
            //********
            var totalArea = Area(shapes);
            Console.WriteLine(totalArea);
        }

        

        public OpenClosedPrinciple(Polymorphism polymorphic)
        {
            _polymorphic = polymorphic;

            /// <image url="$(SolutionDir)Assets\SOLID\ThePolymorphicOpenClosedPrinciple.PNG" scale="0.5" /> 
            /// <summary>
            /// The Polymorphic Open/Closed Principle. 
            /// It uses interfaces instead of super classes to allow different implementations 
            /// which you can easily substitute without changing the code that uses them.
            /// </summary>

            //Step One
            SetupBasicCoffeeApp();

            //Step Two
            SetupCoffeeApp();
        }

        private void SetupBasicCoffeeApp()
        {
            // create a Map of available coffee beans
            var beans = new Dictionary<CoffeeSelection, GroundCoffee>();
            beans[CoffeeSelection.FILTER_COFFEE] = new GroundCoffee("My favorite filter coffee bean", 1000);

            // get a new CoffeeMachine object
            var machine = new BasicCoffeeMachine(beans);

            // Instantiate CoffeeApp
            var app = new BasicCoffeeApp(machine);

            // brew a fresh coffee
            try
            {
                app.PrepareCoffee(CoffeeSelection.FILTER_COFFEE);
            }
            catch (CoffeeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

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

            // brew a fresh coffee
            try
            {
                app.PrepareCoffee(CoffeeSelection.FILTER_COFFEE);
            }
            catch (CoffeeException e)
            {
                Console.WriteLine(e.Message);
            }
        }


        private static double Area(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }

        private Shape[] Shapes()
        {
            //Area Calculator 
            var shapes = new Shape[3];
            var rectangle = new Rectangle();
            rectangle.Width = 4;
            rectangle.Height = 6;
            shapes[0] = rectangle;
            var circle = new Circle();
            circle.Radius = 3;
            shapes[1] = circle;
            var triangle = new Triangle();
            triangle.Base = 3;
            triangle.Height = 7;
            shapes[2] = triangle;

            return shapes;
        }

    }
}
