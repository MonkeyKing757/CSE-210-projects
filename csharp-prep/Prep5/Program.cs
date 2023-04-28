using System;
namespace Prep5
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcome();

            string userName = PromptUserName();
            int userNumber = PromptUserNumber();

            int squared = SquareNumber(userNumber);

            DisplayResult(userName,squared);
        }

        static void DisplayWelcome()
        {
          Console.WriteLine("Welcome To the Program!");  
        }
        static string PromptUserName()
        {
            Console.Write("please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine()); // why do I need to use "int.Parse" for integers?
            return number;
        }
        static int SquareNumber(int number)
        {
            int square = number * number ;
            return square;
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}
