
using SOLID.Models;

/// <summary>
/// Interface Segregation Principle
/// </summary>
/// <image url="C:\Users\Anyx\Pictures\SOLID\InterfaceSegregationPrinciple.PNG" scale="0.8" /> 
namespace InterfaceSegregationPrinciple.Models
{
    public class InterfaceSegregationPrinciple
    {
        public InterfaceSegregationPrinciple()
        {
            var author = new Person("Robert", "Cecil", "Martin ", "Uncle Bob");

            author.Greets();
            /// <summary>
            /// The Interface Segregation Principle was defined by Robert C. Martin 
            /// while consulting for Xerox to help them build the software for their new printer systems.
            /// 
            /// "Clients should not be forced to depend upon interfaces that they do not use.”
            /// </summary>
            /// <image url="C:\Users\Anyx\Pictures\SOLID\YouDontSay.png" scale="0.5" /> 
        }
    }
}
