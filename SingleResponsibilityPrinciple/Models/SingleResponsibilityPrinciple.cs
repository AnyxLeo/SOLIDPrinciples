using System.Collections.Generic;
/// <summary>
/// The single-responsibility principle (SRP)
/// </summary>
/// <image url="C:\Users\Anyx\Pictures\SOLID\SRP.PNG" scale="0.5" /> 
/// <summary>
/// A class should have one, and only one, reason to change.
/// </summary>
namespace SingleResponsibilityPrinciple.Models
{
    /// <summary>
    ///     - Requirements change over time.
    ///     - Depending on your change, you might need to update the dependencies or recompile the dependent classes even though they are not directly affected by your change.   
    /// </summary>
    /// <image url="C:\Users\Anyx\Pictures\SOLID\Invoice1.PNG" scale="1" /> 
    public class SingleResponsibilityPrinciple
    {
        public List<string> Benefits { get; set; }
        public List<string> Recommendations { get; set; }


        public SingleResponsibilityPrinciple()
        {
            Benefits.Add("It makes your software easier to implement");
            Benefits.Add("Prevents unexpected side-effects of future changes"); 
            Benefits.Add("Reduces the number of bugs");
            Benefits.Add("Unit testing code suddenly becomes easier");
            Benefits.Add("Improves your development speed");
            Benefits.Add("Makes your life as a software developer a lot easier.");

            Recommendations.Add("not oversimplify");
            //Go to examples.
        }

        ///<image url = "C:\Users\Anyx\Pictures\SOLID\Question.PNG" scale="1" /> 
    }
}
