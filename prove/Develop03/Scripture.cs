using System;

namespace Develop03
{
    // The responsibility of a Scripture is to spit out the reference text.
    public class Scripture
    {
        // using the data below will used by "SpitOutReferenceText"
        private string _referenceText = " "; 
        // line 11 is a construtor to reuse the "box" scripture in program
        // for example, Scripture s = new Scripture("some text");
        public Scripture(string referenceText)
        {
            _referenceText = $"The reference is: {referenceText}";
        }

        public void SpitOutReferenceText()
        {
            Console.WriteLine(_referenceText);
        }
    }
}