using System;
namespace Learning04
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment a1 = new Assignment("Fatty Arbuckle", "Multiplication");
            Console.WriteLine(a1.GetSummary());

            Math a2 = new Math("Justin Maynes", "Fractions", "7.3", "8-19");
            Console.WriteLine(a2.GetSummary());
            Console.WriteLine(a2.GetHomeworkList());

            Writing a3 = new Writing("Mary Waters", "European History", "The Causes of World War II");
            Console.WriteLine(a3.GetSummary());
            Console.WriteLine(a3.GetWritingInformation());

        }
    }
}