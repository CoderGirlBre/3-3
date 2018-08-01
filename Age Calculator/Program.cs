using System;

namespace Age_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title
            Console.WriteLine("Age Calculator");

            //Allows the user to input the current year.
            Console.Write("Enter the current year: ");

            //Reads the user's input and assigns it to a variable called currentYear.
            string currentYear = Console.ReadLine();

            //Allows the user to input their birth year.
            Console.Write("Enter your birth year: ");

            //Reads the user's input and assigns it to a variable called birthYear.
           string birthYear = Console.ReadLine();

            //This is how you convert the strings to integers. This is done when you are dealing with whole numbers.
            int firstYear = int.Parse(currentYear);
            int secondYear = int.Parse(birthYear);

            //This means subtracting the two integers will give me a new number that I want to assign to a variable called age.
            int age = firstYear - secondYear;

            //The + signs mean "and."
            //Print "You are" and the age, and a space, and "years old." to the console.
            Console.WriteLine("You are " + age + " " + "years old.");
            Console.ReadLine();

            //Statement: like a sentence. It's a complete, finished thought.
            //ex: Console.Write("Enter your birth year: ");

            //Expression: means to evaluate with the given operators and operands.
            //ex: int age = firstYear - secondYear;

            //Operator: tells you how to evaluate the operands in the expression. 
            //ex: int age = firstYear - secondYear;
            // int, =, -, and ; are all operators. Verbs are operators as well.

            //Operand: this is what's being evaluated or assigned to something in expressions.
            //ex: int age = firstYear - secondYear;
            // age, firstYear, and secondYear are the operands.
            
        }
    }
}
