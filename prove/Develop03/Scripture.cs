using System;

namespace Develop03
{
    // The responsibility of a Scripture is to spit out the reference text.
    public class Scripture
    {
        // using the data below will used by "SpitOutReferenceText"
        private string _referenceText = " "; 
        private Verse _verse;
        // line 12 is a construtor to reuse the "box" scripture in program
        // for example, Scripture s = new Scripture("some text");
        public Scripture()
        {
            LoadScripture();
        }

        public void SpitOutReferenceText()
        {
            Console.WriteLine(_referenceText);
        }

        public void SetVerse(string verseText)
        {
            _verse = new Verse(verseText);
        }

        public void LoadScripture()
        {
            string filename = "Scipture.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach(string line in lines)
            {
                string[] parts = line.Split("|");
                _referenceText = $"The reference is: {parts[0]}";
                SetVerse(parts[1]);
            }
        }

        public void VerseSpit()
        {
            _verse.VerseSpit();
        }
        
    }
}