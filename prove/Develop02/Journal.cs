using System.Collections.Generic;

namespace Develop02
{
     /// </summary> 
    /// the responsibility of an entry is to record (or to store) a prompt,
    ///</summary>
    public class Journal 
    {
       public List<Entry> entries;

       public List<Entry> GetAllEntries()
       {
           return entries;
       }
       public Journal()
       {
            entries = new List<Entry>();
       }
       public void StoreEntry(Entry entry)
       {
            // this below is saying if the entry is not already there add it
           if ( !entries.Contains(entry))
           {
               entries.Add(entry);
           }
       }
       public void save()
       {
            string filename = "Journal.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach(string line in lines)
            {
                string[] parts = line.Split(",");
                string prompt = parts[0];
                string response =  parts[1];
                string date = parts[2];
                Entry entry = new Entry();
                entry.store(prompt, response, date);
                StoreEntry(entry);

            }
       }
    }
}