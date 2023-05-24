using System;
namespace Develop03
{
    public class Verse
    {
        // The Lines below will be for verses in the scripture
        private string _verseText = " ";
        // constructor is below for this class
        public Verse(string verseText)
        {
            _verseText = $"The verse is: {verseText}";
        }
        public void VerseSpit()
        {
            Console.WriteLine(_verseText);
        }
    }
}