using System;

namespace Develop04
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