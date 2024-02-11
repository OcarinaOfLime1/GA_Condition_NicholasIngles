// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;

class Program
{
    // Entry point of C# program
    static void Main(string[] args)
    {
        Console.WriteLine("Hi there. I'm thinking of a number, so go ahead and pick a number between one and ten.(lower case letters only)");
        string guess = Console.ReadLine();

        string right = "four";
        string oneless = "three";
        string onemore = "five";



        Console.WriteLine("\nThinking...\n");

        if (guess == right)
            {
            Console.WriteLine("Yup.");

        }
        else
        {
            if (guess == oneless)
            {
                Console.WriteLine("Nope. Close though!");
                Console.WriteLine("Play again");
            }
            else if (guess == onemore)
            {
                Console.WriteLine("Nope. Close though!");
                    Console.WriteLine("Play again");
            }
            else

            { Console.WriteLine("Not even close.");
                Console.WriteLine("Play again");
                }


        }




        







    }
}
