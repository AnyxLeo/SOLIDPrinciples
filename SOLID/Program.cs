using SOLID.Models;
using System;


/// <image url="C:\Users\Anyx\Pictures\SOLID\SolidPrinciples.PNG" scale="1" /> 
/// <summary>
/// The Golden Rules.
/// Objective:
/// Develop software that is: 
///     - Flexible.
///     - Easy to maintain.
///     - Easy to read and understand.
///     - Easy to test.
///     - Easy to extend.
///     - Reduce dependencies.
/// </summary>

namespace SOLID
{
    public class Program
    {
        static void Main(string[] args)
        {
            var author = new Person ("Robert", "Cecil", "Martin ", "Uncle Bob");

            author.Greets();
            /// <summary>
            /// Martin has authored many books and magazine articles.
            /// </summary>
            /// <image url="C:\Users\Anyx\Pictures\SOLID\clean-code-uncle-bob.jpg" scale="1" /> 

            Console.ReadLine();
        }
    }
}
