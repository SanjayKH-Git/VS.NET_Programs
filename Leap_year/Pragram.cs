using System;

namespace Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Year:");
            int y=int.Parse(Console.ReadLine());
            if((y%4==0 && y%100!=0) ||(y%400==0))
                Console.WriteLine("{0} is a Leap Year", y);
            else
                Console.WriteLine("{0} is not a Leap Year", y);
            Console.Read();

        }
        
    }
}
