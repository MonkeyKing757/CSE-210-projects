using System;
using System.Collections.Generic;
namespace learning02
{
    public class Resume
    {
        public string _name;
        public List<Jobs> _jobs = new List<Jobs>(); // ! something is wrong in this code
        
        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("jobs: ");

            foreach (Jobs job in _jobs)
            {
                job.Display();
            }
        }
    }
}