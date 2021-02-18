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
        {
            Console.WriteLine("Henlo World!~");
        }
    }
}
