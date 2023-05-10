using System;
namespace Develop02
{

    class Program
    {
        static void Main(string[] args)
        {
            Entry myEntry = new Entry();
            myEntry.store("what is your name?","jacob todd", "8 may 2023");

            Journal journal = new Journal();
            journal.StoreEntry(myEntry);

            List<Entry> entries = journal.GetAllEntries();
            foreach(Entry entry in entries)
            {
                string message = entry.GetAsString();
                Console.WriteLine(message);
            }

        }
    }
}