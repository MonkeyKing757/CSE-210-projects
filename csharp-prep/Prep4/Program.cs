using System;
using System.Collections.Generic; // to use the library for lists
namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(); // how to make a list for integers.
                
            int userNumber = -1; // just to help run the while loop
            while (userNumber != 0)
            {
                Console.WriteLine("Enter a list of numbers, type 0 when finished.");

                string userResponse = Console.ReadLine();
                userNumber = int.Parse(userResponse);

                if (userNumber!=0)
                {
                    numbers.Add(userNumber); // adding the userNumber to the list
                }
            }

            // computing the sum of the total list
            int sum = 0;
            // The "number" is just a random name to look through the List of "numbers"
            foreach (int number in numbers) 
            {
                sum += number; // doing the calculations to add the numbers
            }
            Console.WriteLine($"the sum is: {sum}");
            // computing the average
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");
            
            int max = -100;
            foreach (int maxnumber in numbers)
            {
                if (maxnumber > max)
                {
                    max = maxnumber;
                }
            }
            Console.WriteLine(($"The max number is: {max}"));
            
        }
    }
}