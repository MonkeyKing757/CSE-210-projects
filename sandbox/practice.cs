using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Your Grade percentage: ");
        string grade=Console.ReadLine();
        int x = int.Parse(grade);
        string letter="";
        {
            if (x >= 90)
            {
                Console.WriteLine("Your grade is a A.");
            }
            else if (x < 90 && x >=80)
            {
                Console.WriteLine("Your grade is a B.");
            }
            else if (x >= 70 && x < 80 )
            {
                Console.WriteLine("your grade is a C.");
            }
            else if (x >= 60 && x < 70 )
            {
                Console.WriteLine("Your grade is a D.");
            }
            else
            {
                Console.WriteLine("Your grade is a F.");
            }
        if (x > 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("sorry you failed the class. Try again next time.");
        }
        }
    }
}