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
           if (!entries.Contains(entry))
           {
               entries.Add(entry);
           }
       }
    }
}