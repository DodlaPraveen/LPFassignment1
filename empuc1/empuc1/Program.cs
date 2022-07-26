using System;

namespace empuc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            if(name == "Praveen")
            {
                Console.WriteLine("Name is ok");
            }
            else
            {
                Console.WriteLine("Name is not ok");
            }
        }
    }
}
