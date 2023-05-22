using System;

class Program
{
    static void Main(string[] args)
    {
        Cake c1 = new Cake("chocolate");
        Cake c2 = new Cake("vanilla");
        Cake c3 = new Cake("strawberry");
        
        c1.Taste();
        c2.Taste();
        c3.Taste();
        
        
        
    }
}