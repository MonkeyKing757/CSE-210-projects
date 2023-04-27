using System;
namespace Practice
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Random randomGenerator = new Random(); // gets a system that makes it so we can generate a random number
            int magicNumber = randomGenerator.Next(1,11); // this is where the random number comes from

            int guess = -1; // why is the int guess "-1" ???

            while (guess != magicNumber)
            {
                Console.Write("what is your guess? "); // writing the question
                guess=int.Parse(Console.ReadLine()); // saving the answer and seeing if it is equal to the magic number
                if (guess > magicNumber);
                {
                    Console.Write("Lower");
                }

                
            }
            


        }
    }
}
