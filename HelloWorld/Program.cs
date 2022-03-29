using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // SingelLine comment

            /*
             Understande multiline comment.
             */

            /*
            
             ========================> DATATYPE'S OF C# <========================
               
             1) Integer -> int number = 5; [Data-Type Size = 4 bytes]
             
             2) Floatin Integer -> float floatingNumber = 2.21; [Data-Type Size = 4 bytes]

             3) String -> string name = "kashyap" [Data-Type Size = 2 bytes per character]

             4) Character -> char character = 'K' [Data-Type Size = 2 bytes]

             5) Blooean -> bool isActive = true [Data-Type Size = 1 bit]

             6) Long -> long number = 90123490123456648950 [Data-Type Size = 8 bytes] (Good presition form Integer)

             7) Double -> double number = 9.490123456648950 [Data-Type Size = 8 bytes] (Good presition form Float)

             */

            // Usage of DATATYPE'S as per above we write (Examples)

            Console.WriteLine("========================> DATATYPE'S OF C# <========================");

            int number1 = 5;

            float number2 = 5.20F;

            string name = "kashyap";

            char firstLatterOfName = 'k';

            bool isActive = true;

            double sumOfTwoNumbers = number1 + number2;

            Console.WriteLine("Hello World!" + number1 + " " + number2);

            Console.WriteLine("1) Person Name is: " + name + " 2) First Latter Of Name is: " + firstLatterOfName + " 3) Person is active or not: " + isActive);

            Console.WriteLine("Sum of Two Numbers: " + sumOfTwoNumbers);

            //Type Casting

            Console.WriteLine("========================> TYPE-CASTING In C# <========================");

            /*
             There are a two type's of type casting in C#.

             1) Implicit type-casting.
                char <-> int <-> float <-> long <-> double

             2) Explicit type-casting.

             */

            // 1) Implicit type-casting.

            int typeCastingNumber = 5;

            double intToDouble = typeCastingNumber;

            int intToCharacter = 'n';

            Console.WriteLine("Implicit Type Casting Integer To Dobule: " + intToDouble);

            Console.WriteLine("Implicit Type Casting Integer To Character: " + intToCharacter); // here we get answer 110 becuse compiler give us ASCII value of the character.

            //2) Explicit type-casting.

            double coverIntToDobule = (int)30.90;

            Console.WriteLine(coverIntToDobule);

            //Take Input From User

            Console.WriteLine("========================> TAKING-INPUT-FROM-USER In C# <========================");

            Console.WriteLine("Please, enter your name: ");
            // string personName = Console.ReadLine();
            // Console.WriteLine("Hello, welcome Mr/Miss: " + personName);

            Console.WriteLine("How many candies do you want: ");
            // string cadiesNumber = Console.ReadLine();
            // Console.WriteLine("You will get 5 more candies from use: " + (Convert.ToInt32(cadiesNumber) + 5));

            // Operator in c# 

            /*
                1)  Arithmetic Operator
                2)  Assignmet Operator 
                3)  Logical Operator
                4)  Comparison Operator
            */

            Console.WriteLine("========================> ARITHMATIC-OPERATOR In C# <========================");

            Console.WriteLine("Additino of two numbers: " + (5 + 2));
            Console.WriteLine("Subtraction of two numbers: " + (5 - 2));
            Console.WriteLine("Divition of two numbers: " + (5 / 2));
            Console.WriteLine("Multiplication of two numbers: " + (5 * 2));
        }
    }
}