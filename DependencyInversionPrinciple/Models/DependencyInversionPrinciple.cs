using SOLID.Models;

vbusing SOLID.Models;

/// <summary>
/// Dependency Inversion Principle
/// </summary>
/// <image url="C:\Users\Anyx\Pictures\SOLID\di.PNG" scale="0.5" /> 
namespace DependencyInversionPrinciple.Models
{
    /// <summary>
    /// "High-level modules, which provide complex logic, should be easily reusable and unaffected by changes in low-level modules, which provide utility features.
    /// To achieve that, you need to introduce an abstraction that decouples the high-level and low-level modules from each other."
    /// </summary>
    public class DependencyInversionPrinciple
    {
        public DependencyInversionPrinciple()
        {
            var author = new Person("Robert", "Cecil", "Martin ", "Uncle Bob");

            author.Greets();
            /// <summary>
            /// Based on this idea, Robert C. Martin’s definition of the Dependency Inversion Principle consists of two parts:
            ///
            ///1.- High-level modules should not depend on low-level modules. Both should depend on abstractions.
            ///2.- Abstractions should not depend on details. Details should depend on abstractions.
            /// </summary>
            /// <image url="C:\Users\Anyx\Pictures\SOLID\DependencyInversionPrinciple.png" scale="1" /> 
        }
    }
   
}
