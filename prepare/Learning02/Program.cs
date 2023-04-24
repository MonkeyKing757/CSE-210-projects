using System;
using System.Collections.Generic;
// commenting
namespace learning02 // this namespace acts like folders in a computer where this code will not interact with other code.
{
    public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
    }
}
}
// this code below is how to make a list
namespace learning
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Learning02 World!");
            List<int> myList=new List<int>(); // making list
            myList.Add(121);
            myList.Add(2021);
            myList.RemoveAt(0); // you can remove things from the list by the index
        }
}
}

