using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("what is your first name? ");
        string f_name=Console.ReadLine();
        Console.Write("what is your last name? ");
        string L_name=Console.ReadLine();
        Console.WriteLine($"Your name is {L_name}, {f_name} {L_name}. ");

    }
}