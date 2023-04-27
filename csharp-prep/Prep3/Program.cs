using System;
namespace Prep3
{
    class Program
    {
    static void Main(string[] args)
        {
            
            Random randomGenerator = new Random();
            int magicnumber = randomGenerator.Next(1,101); // this is the magic number that we put in

            int guess = -1; // this is so that there is a guess but its not right so we can just see the while loop

            int count = 0; // this is to count the users input

            while (guess != magicnumber)
            {
                count = count +1;
                Console.Write("what is your guess? ");
                guess = int.Parse(Console.ReadLine());
                if (guess == magicnumber)
                {
                   Console.WriteLine("Correct");
                   Console.WriteLine($"your Total guesses is {count}");
                }
                else if (guess < magicnumber)
                {
                    Console.WriteLine("higher");
                }
                else
                {
                    Console.WriteLine("lower");
                }
            }

        }
    }
}