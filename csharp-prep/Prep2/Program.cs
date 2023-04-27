using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Your Grade percentage: "); // writing the question
        string grade = Console.ReadLine(); // saving the answer in this String "grade"
        int x = int.Parse(grade); // converts the string to a integer "x" to save for later
        string letter = ""; // "letter" this saves the answer in the if statements that are most correct.
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