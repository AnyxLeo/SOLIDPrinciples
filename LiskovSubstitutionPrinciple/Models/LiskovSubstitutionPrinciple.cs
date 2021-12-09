

using SOLID.Models;
using System;
using System.Collections.Generic;
/// <summary>
/// Liskov Substitution Principle
/// </summary>
/// <image url="C:\Users\Anyx\Pictures\SOLID\LiskovSubstitutionPrinciple.PNG" scale="1" /> 
namespace LiskovSubstitutionPrinciple.Models
{    
    public class LiskovSubstitutionPrinciple
    {
        public LiskovSubstitutionPrinciple()
        {
            var authors = new List<Person>() { 
                new Person("Barbara", "Liskov ", " ", ""),
                new Person("Jeanette", "Wing ", " ", ""),
            };

            /// <image url="C:\Users\Anyx\Pictures\SOLID\BarbaraLiskovAndJanetteWing.png" scale="0.8" /> 

            authors[0].Greets();
            authors[1].Greets();
            /// <summary>
            /// The Liskov Substitution principle was introduced by Barbara Liskov in her conference keynote “Data abstraction” in 1987.
            /// A few years later, she published a paper with Jeanette Wing in which they defined the principle as:
            /// 
            /// Let Φ(x) be a property provable about objects x of type T.
            /// Then Φ(y) should be true for objects y of type S where S is a subtype of T.
            /// 
            /// <image url="C:\Users\Anyx\Pictures\SOLID\whaaaat.jpg" scale="0.2" />
         

            /// <summary>
            /// “The principle defines that objects of a superclass 
            /// shall be replaceable with objects of its subclasses without breaking the application. ”
            /// </summary>
            /// <image url="C:\Users\Anyx\Pictures\SOLID\Igotit.png" scale="" />


            /// <summary>
            /// “Requirements:”
            ///     - That requires the objects of your subclasses to behave in the same way as the objects of your superclass.
            ///     - The behavior of your classes becomes more important than its structure. 
            ///     - You need to implement your own checks.
            /// </summary>
            /// 
            Console.ReadLine();
        }
    }
}
