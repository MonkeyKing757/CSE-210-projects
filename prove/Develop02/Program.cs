using System;
using System.Collections.Generic;
using System.IO;
namespace Develop02
{

    public class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            int userInput = -1;
            Console.WriteLine("Welcome to the Journal Program!");
            while(userInput != 5)
            {
                Console.WriteLine("please select one of the following choices: ");
                Console.WriteLine("1. Write ");
                Console.WriteLine("2. Display ");
                Console.WriteLine("3. Save ");
                Console.WriteLine("4. Load ");
                Console.WriteLine("5. Quit ");
                Console.WriteLine("What would you like to do? ");
                string rawinput = Console.ReadLine();
                userInput = int.Parse(rawinput);
                
                if (userInput == 1) 
                {
                    // writing the a new entry and displaying a random question
                    string[] questions = new string[7];
                    questions[0] = "Who was the most interesting person I interacted with today? ";
                    questions[1] = "What was the best part of my day?";
                    questions[2] = "How did I see the hand of the Lord in my life today?";
                    questions[3] = "What was the strongest emotion I felt today";
                    questions[4] = "If I had one thing I could do over today, what would it be?";
                    questions[5] = "who was the most attractive person you saw today?";
                    questions[6] = "What was the weather like today?";
                    
                    Random rnd = new Random();
                    string prompt = questions[rnd.Next(0,6)];
                    Console.WriteLine(prompt);

                    // storing the users answer from the prompt
                    string response = Console.ReadLine();
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();

                    Entry entry = new Entry();
                    entry.store(prompt, response, dateText);

                    journal.StoreEntry(entry);

                }
                else if (userInput == 2)
                {
                    // Displaying what entries have been written before
                    
                    List<Entry> entries = journal.GetAllEntries();
                    foreach(Entry entry in entries)
                    {
                        string message = entry.GetAsString();
                        Console.WriteLine(message);
                    }
        

                }
                else if (userInput == 3)
                {
                    // save the journal to a file
                    SaveToFile(journal.entries);
                }
                else if (userInput == 4)
                {
                    // load the journal from a file

                    journal.save();
                }                   
            }
        }
        // this code below will send the entries into a txt file.
        public static void SaveToFile(List<Entry>Entry)
        {
            string filename = "Journal.txt";
            using (StreamWriter outputfile = new StreamWriter(filename))
            {
                foreach(Entry e in Entry)
                {
                    outputfile.WriteLine($"{e.prompt},{e.response},{e.date}");
                }
            }
        }

    }
}