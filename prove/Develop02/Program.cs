using System;
using System.Collections.Generic;
using System.IO;
namespace Develop02
{

    public class Program
    {
        static void Main(string[] args)
        {
            Entry myEntry = new Entry();
            Console.Write("What is your Name? :"); 
            if (myEntry = 1) 
            {
                // writing the a new entry and displaying a random question

    
            }

            Journal journal = new Journal();
            journal.StoreEntry(myEntry);

            List<Entry> entries = journal.GetAllEntries();
            foreach(Entry entry in entries)
            {
                string message = entry.GetAsString();
                Console.WriteLine(message);
            }

        }
        // this code below will send the entries into a txt file.
        public static void SaveToFile(List<Journal>Entry)
        {

        }

    }
}