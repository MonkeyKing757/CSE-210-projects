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
                letter="A";
            }
            else if (x < 90 && x >=80)
            {
                letter="B";;
            }
            else if (x >= 70 && x < 80 )
            {
                letter="C";
            }
            else if (x >= 60 && x < 70 )
            {
                letter="D";
            }
            else
            {
                letter="F";
            }
            Console.WriteLine($"Your grade is: {letter}");
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