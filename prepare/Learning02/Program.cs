using System;
using System.Collections.Generic;
// commenting
namespace learning02 // this namespace acts like folders in a computer where this code will not interact with other code.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Jobs job1 = new Jobs();
            job1._company = "microsoft";
            job1._jobTitle = "Softwear Engineer";
            job1._startYear = 2019;
            job1._endYear = 2022;

            Jobs job2 = new Jobs();
            job1._company = "Apple";
            job1._jobTitle ="Manager";
            job1._startYear = 2022;
            job1._endYear = 2023;

            Resume myresume = new Resume();
            myresume._name = "Jacob Todd";
            
            myresume._jobs.Add(job1);
            myresume._jobs.Add(job2);

            myresume.Display();
        }
    }
}
