using System;

namespace Develop03
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            Scripture s = new Scripture();
            // Scripture b = new Scripture("Matt 1:9");
            
            s.SpitOutReferenceText();
            s.VerseSpit();
            // b.SpitOutReferenceText();
        }
    }
}