using System;

namespace empuc1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fullTime = 1;
            int wagehour = 20;
            int emphr;
            Random random = new Random();
            int value = random.Next(0,2);
            if(value == fullTime)
            {
                emphr = 8;

            }
            else
            {
                emphr = 4;
            }
            
            
            Console.WriteLine("Emphe="+emphr+ "empwasehour="+(wagehour*emphr));
            
        }
    }
}
