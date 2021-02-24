using System;
using System.Globalization;
using System.IO;
// using System.Text;

// * !!! C# Fundamentals R E P S ~ *

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
    enum birdFrands {
                Pigeon,
                mourningDove,
                Cardinal,
                songSparrow,
                Bluejay
            }
    
    public struct bookList {
        public string title;
        public string author;
        public double price;
    }

    class Program
    {
        static void Main(string[] args)
        {   // * below is an example of a statement => actions that a program takes are expressed within -> common ones include declaring variables, assigning values, calling methods/funcs, looping, etc.
            Console.WriteLine("Henlo World!~");

            // * below are examples of V A R I A B L E S ~ aka name identifiers that can be assigned to a variable
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

            // Console.WriteLine($"Henlo~ {firstName}! Please provide your unique identifier label {firstLetter} in the field below. If you wish to skip coffee, indicate here {didYouHaveCoffeeAlready}. Great news! Your Angel Number for the day is {angelNumber}. Here are some more funky numbers {min} and {pi}. Enjoy!");

            // * MIN/MAX VALUES EXERCISE:
            int maxValue = int.MaxValue;
            maxValue += 1;
            // Console.WriteLine($"Check out what happens when we increment an int to max value: {maxValue}");

            // * IMPLICIT TYPES:
            // pro-tip: vars must have a type + cannot change after they are declared (can only contain values that match their type)
            // using the var keyword allows the compiler to determine type by evaluating the value on the right side of the equals sign => only works if the variable is being I N I T I A L I Z E D ~
            var areYouCaffienated =true;
            var thisIsAnInt = 444;
            var thisIsADouble = 1.5;
            var thisIsALetter = 'Z';
            var thisIsAString = "Get me coffee please!";
            // Console.WriteLine($"Implicit types are as follows: boolean -> {areYouCaffienated}, int -> {thisIsAnInt}, double -> {thisIsADouble} -> {thisIsALetter}, -> {thisIsAString}");

            // * O P E R A T O R S:
            int x = 1111;
            int y = 555;
            int z1 = x += 1;
            int z2 = ++y;
            // Console.WriteLine($"~** OPERATORS **~ The values of int x & y are: {x}, {y}. The values of int z1 & z2 are {z1}, {z2}. Ayyyye ~");

            // * M A T H 
            int xMath = 333;
            int yMath = 222;
            int zMath = 888;
            int aMath = (xMath + zMath) * yMath;
            int bMath = xMath + yMath + zMath;
            int cMath = xMath % (yMath * zMath);
            var isXMathEven = xMath % 2 == 0 ? true : false;
            var isYDivisibleBy3 = yMath % 3 == 0 ? true : false;
            double roundDoubleToThreeDecimalPlaces = Math.Round(3.14159, 3);
            // Console.WriteLine($"*~ M A T H *~ : {roundDoubleToThreeDecimalPlaces}");

            // * T Y P E ~ CONVERSIONS!
            int typeX = 555;
            int typeY = 777;
            int typeZ = 1234;
            double typeA = 15551;
            double typeB = 777.777;
            double typeC = 123.456;
            // pro-tip: ints can be stored in a double
            // no special syntax is required bc the conversion is type safe, no data will be lost => implicit conversion
            double typeDoubleX = typeX;
            double typeDoubleY = typeY;
            double typeDoubleZ = typeZ;
            // ~ EXPLICIT conversion => requires a (CAST) operator because the information might be lost
            // * int typeIntA = typeA; => this does not compile because a double is LARGER than an int -> in this example all the decimal places will be lost
            // * to store a double in an int => you have to (CAST) the double to the int type
            int typeIntA = (int)typeA;
            int typeIntB = (int)typeB; // -> will contain only int part of the double, no rounding occurs just takes the in part minus decimal places
            int typeIntC = (int)typeC;
            // more explicit conversion examples:
            int xCastExample = 4;
            int yCastExample = 5;
            double zCastExample = 4 / 5; // -> returns int part of 0.8 = 0
            // * fix with casting:
            // will force the expression to evaluate to a double by casting either operand in the division expression to a double
            double zCasted = (double) 4 / 5;    
            // Console.WriteLine($"*~ TYPE CONVERSIONS *~ : {xCastExample}, {yCastExample}, {zCastExample}, {zCasted}");

            // * S T R I N G S!
            var filePath = "c:\\practiceFiles\\practiceExercise.txt";
            var multiLineString = "Henlo!~ This is a string\nthat prints\non three lines";
            // string literals: starts w @ symbol => v useful for file paths
            var filePath2 = @"c:\practiceFiles\stringLiterals.txt";
            // Console.WriteLine($"*~ S T R I N G S *~ : Here is an example of escape sequences: FilePath = {filePath}, Multiple Lines: {multiLineString}, stringLiterals: {filePath2}");
            // * pro-tip on string operations: none of the operations change the existing string -- they return new ones!
            string greeting = "Henlo~! Nice to meet ya,";
            string firstName2 = "McKinsey!";
            string pickYoFlavor = "Spicy or Nah?";
            string pickYoFlavor2 = "Sweet or Salty?";
            string comboFlavors = pickYoFlavor + " " + pickYoFlavor2;
            Console.WriteLine($"{greeting} {firstName2} Would you like something to eat? {pickYoFlavor} ...or {comboFlavors}");
            // accessing length property
            Console.WriteLine($"Phrase: {greeting} // Length: {greeting.Length}");
            // indexing ~
            string indexPractice = "fakejerseyy";
            int middle = indexPractice.Length % 2 == 1 ? indexPractice.Length / 2 : indexPractice.Length / 2 - 1;
            char firstIndexChar = indexPractice[0];
            char middleIndexChar = indexPractice[middle];
            char lastIndexChar = indexPractice[indexPractice.Length - 1];
            string indexPracticeConcat = String.Concat(firstIndexChar, middleIndexChar, lastIndexChar);
            Console.WriteLine($"In all caps: {indexPractice.ToUpper()}, in all lowercase: {indexPractice.ToLower()}, concatenated with first, mid, last char: {indexPracticeConcat}");
            // trimming / getting parts of strings
            string trimThis = "Wonderland";
            // string trimThisEnd = trimThis.TrimEnd('d');
            // string trimThisBoth = trimThisEnd.TrimStart('W');
            string trimThisSubstring = trimThis.Substring(1, trimThis.Length - 1);
            // string trimThisSubstring = trimThis.Remove(trimThis.Length - 1, 1);
            Console.WriteLine($"~* TRIMMED STRING *~ : {trimThisSubstring}");
            // ~ S E A R C H I N G ~
            string xSearch = "21savage";
            string ySearch = "metroboomin";
            int indexYFirstOccurrence = xSearch.IndexOf('e');
            bool isYCharInXSearch = xSearch.Contains(ySearch);
            Console.WriteLine($"Index of first Occurence of char Y in string X: {indexYFirstOccurrence} // Contains(): {isYCharInXSearch}");
            string searchFilePath = @"c:\21savage-metro-boomin\savagemode\ii.mp8";
            string path = @"C:\21savage-metro-boomin\savagemode\";
            string searchFilePathNoExt;
            searchFilePathNoExt = Path.GetFileNameWithoutExtension(searchFilePath);
            char searchFilePathDriveLetter = path[0];
            Console.WriteLine($"~*F I L E NAME W/O EXT: {searchFilePathNoExt} // PATH DRIVE LETTER IN CAPS: {searchFilePathDriveLetter}");
            // S P L I T T I N G:
            string splitExample = "mool mantra by martyrs of sound";
            string[] splitString = splitExample.Split(' ');
            Console.WriteLine($"~* S P L I T string: {splitString}");
            // FORMATTING STRINGS
            // * pro-tip: if you need to insert a value of an object, variable, or expression into another string. ex: insert the value of a decimal
            decimal formatPrice = 11.11m;
            string formatPriceString = String.Format("The current price is {0} per juice box. Yumyum enjoy!", formatPrice);
            Console.WriteLine($"~* FORMATTING string: {formatPriceString}");
            double formatPrice2 = 123.456;
            string formatPriceString2 = String.Format(formatPrice2 % 1 == 0 ? "{0:0}" : "{0:0.00}", formatPrice2);
            Console.WriteLine($"~* FORMATTING DOUBLE string: {formatPriceString2}");

            // E N U M E R A T I O N S ~
            // a distinct type consisting of a set of named constants => typically used to store a collection of related values
            // each constant is accessed by name but also has a numeric value -> default type is int, starts at 0 incremented by 1
            var faveBirdFriend = birdFrands.Cardinal;
            // to convert from enum to int, cast it!
            var faveBirdFriendInt = (int) faveBirdFriend;
            Console.WriteLine($"~* ENUMS *~ : faveBird: {faveBirdFriend} // faveBirdInt: {faveBirdFriendInt}");

            // S T R U C T S !!~
            // a type that acts as a container for related variables
            // to initialize a struct type, use NEW~ keyword (instantiation) -- to access struct "members" use the member access operator (dot .)
            // structs are just blueprints
            var firstBookToRead = new bookList();
            firstBookToRead.title = "Bhagavad Gita: A New Translation";
            firstBookToRead.author = "Stephen Mitchell";
            firstBookToRead.price = 13.79;
            Console.WriteLine($"~* S T R U C T: {firstBookToRead.title}");

            // * ~ P A R T II ~ *
            // @CONDITIONALS! -> if / else:
            int conditionalX = 1;
            if(conditionalX < 100) {
                Console.WriteLine($"Integer {conditionalX} is less than 100. Woop~");
            } else if(conditionalX == 100) {
                Console.WriteLine($"Integer {conditionalX} is right on the montey! Woohoo!");
            } else {
                Console.WriteLine($"Integer {conditionalX} is over 100!");
            }

            // @ SWITCH statements ~
            // can only compare against the same value for each check => useful when you know the values you wanna compare against (only equality checks, no < or >)
            // v useful with enums as they're specific, pre-defined values
            // pro-tip: you can stack multiple cases on a "branch" to the same code -> aka falling through the next case
            var birdFrand = birdFrands.Bluejay;
            switch (birdFrand) {
                case birdFrands.Bluejay:
                Console.WriteLine("Ahh the bluejay! An unmistakeable and intelligent friend! You can't miss its perky crest & sounds from this beloved songbird.");
                break;

                case birdFrands.Cardinal:
                Console.WriteLine("The beauty and boldness of a Cardinal is definitely hard to miss! They say if they are near, your ancestors are watching over you and that the angels are near. It is a symbol of love and protection.");
                break;

                case birdFrands.songSparrow:
                Console.WriteLine("This melodious friend is among the most familiar birds in widespread North America. They say this represents hardwork, diligence, and persistence. This spirit guide likes to remind you to express your most creative self and to be happy! (:");
                break;

                case birdFrands.Pigeon:
                Console.WriteLine("The classic NYC bird! Aka Rock Pigeon or Doves, they've learned to adapt in cities. Some think they are a nuisance, but we're not about that energy. They're amazing! Strong fliers, they're actually v clean, and are v smart creatures!");
                break;

                case birdFrands.mourningDove:
                Console.WriteLine("The prescence of a Mourning Dove is rather a rare sight as they aren't easily trustworthy creatures. They're v elegant (yet fierce) and symbolize as a spiritual messenger of love, peace, and faith. They encourage healing and devotion. A beautiful sight!");
                break;

                default:
                Console.WriteLine("The bird friend is waiting! Keep an eye out for these lovely messengers. ~");
                break;
            }

            // order of operations ~
            string orderString = "Good Intentions";
            if(orderString.Length < 5 && orderString.Length % 2 != 0) {
                Console.WriteLine($"~ * O R D E R of Ops: The given string is less than 5 chars long and it is not an even number in terms of l e n g t h."
                );
            } else if(orderString.Length >= 10 && orderString.Length % 2 == 0) {
                Console.WriteLine($"~ * O R D E R of Ops: The given string is greater than or equal to 10 chars long and it is an even number in terms of l e n g t h.");
            } else {
                Console.WriteLine("~ * O R D E R of Ops: The given string does not match the conditional operators in this given exercise.");
            }

            // refactored above using nested conditionals, need to tweak to hit all clauses
            if(orderString.Length < 5) {
                if(orderString.Length % 2 == 1) {
                    Console.WriteLine("Ayy nested conditional over here stating the string given is less than 5 chars long and its pretty uneven.");
                }
            } else if(orderString.Length >= 10) {
                if(orderString.Length % 2 == 0) {
                    Console.WriteLine("Ayy nested conditional over here stating the string given is greater than or equal to 10 chars long and its pretty uneven.");
                }
            } else {
                Console.WriteLine("Ayy nested conditional over here stating the given string does not match any of the above conditions. -___-");
            }

        }   
    }
}


