using System;
using System.Collections.Generic;
using System.IO;
namespace Practice
{
    public class practice_person
    {

        static void Main(string[] args)
        {
            person p1 = new person();
            p1._firstName = "mary";
            p1._lastName = "Smith";
            p1._age = 25;
            
            person p2 = new person();
            p2._firstName = "John";
            p2._lastName = "watkins";
            p2._age = 30;

            List<person> people = new List<person>();
            people.Add(p1);
            people.Add(p2);

            foreach (person p in people) // looping through all the instances of person
            {
                Console.WriteLine(p._firstName);
                
            }
            SaveToFile(people);
        }
    

    public static void SaveToFile(List<person>people)
    {
        string filename = "people.txt";

           using (StreamWriter outputFile = new StreamWriter(filename))
           {
               foreach(person p in people)
               {
                   outputFile.WriteLine(p._firstName);
               }
           }
    }
    }
}