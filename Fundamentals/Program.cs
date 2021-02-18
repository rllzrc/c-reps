using System;

/*
this is an example of a multi-line comment! YAY!
namespace = named groups that contain classes -> all classes must be in a namespace
classes = aka "Program" here => these are named groups that contain code, as all code must be in a class
main method = aka the entry point of the program, where it starts when it is ran
*/

// * .NET Framework => programming infrastructure => FCL = framework class library = a collection of resuable classes, interfaces, and types

// XML documentation comments ->
/// <summary>
/// The below class performs an important function, the main entry point to our exercise Program
/// This will build an XML file of comments upon compilation with the /doc option
// It is to show info to the user through Intellisense
/// This is not metadata; it is not included in the compiled assembly + therefore not accessible through reflection.
/// </summary>

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {   // * below is an example of a statement => actions that a program takes are expressed within -> common ones include declaring variables, assigning values, calling methods/funcs, looping, etc.
            Console.WriteLine("Henlo World!~");

            // * below are examples of variables aka name identifiers that can be assigned to a variable
            // can be updated anytime after they are created aka reassigment 
            // * CONSTANTS are variables whose values can never be changed~ => value set at compile time + must be initialized when they are decalred
            char firstLetter = 'I';
            string firstName = "Izzi";
            bool didYouHaveCoffeeAlready = false;
            int angelNumber = 333;
            // * the M suffix on numbers is how you indicate that a constant should use the decimal type 
            // * decimal type = smaller range but greater precision
            decimal min = 5.0M;
            double pi = 3.14159;

            Console.WriteLine($"Henlo~ {firstName}! Please provide your unique identifier label {firstLetter} in the field below. If you wish to skip coffee, indicate here {didYouHaveCoffeeAlready}. Great news! Your Angel Number for the day is {angelNumber}. Here are some more funky numbers {min} and {pi}. Enjoy!");
        }   
    }
}
