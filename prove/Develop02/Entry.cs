namespace Develop02
{
    /// </summary> 
    /// the responsibility of an entry is to record (or to store) a prompt,
    ///</summary>
    public class Entry
    {
        public string prompt;
        public string response;
        public string date;
        public string GetAsString()
        {
            return $"{date}\n{prompt}\n{response}\n";
        }
        public void store(string prompt, string response, string date)
        {
            
            this.prompt = prompt;
            this.response = response;
            this.date = date;
        }
    }
}