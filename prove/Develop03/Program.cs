using System;

namespace Develop03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Scripture s = new Scripture("John 3:16");
            Scripture b = new Scripture("Matt 1:9");
            s.SpitOutReferenceText();
            b.SpitOutReferenceText();
        }
    }
}