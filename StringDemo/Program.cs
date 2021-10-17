using System;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string fname = "Rajesh";
            string lname = "Yadav";
            Console.WriteLine("My name is "+fname+" "+lname);

            Console.WriteLine($"My name is {fname} {lname}");

            Console.WriteLine(fname[5]);

        }
    }
}
