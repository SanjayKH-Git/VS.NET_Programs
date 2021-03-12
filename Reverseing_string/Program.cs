using System;

namespace Reverse_String
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string mystr = Console.ReadLine();
            Console.WriteLine("Reverse_string: {0}", ReverseString(mystr));
        }        
        public static string ReverseString(string mystr)
        {
            char[] charArray = mystr.ToCharArray();
            Array.Reverse(charArray);
            return new string (charArray);
        }


    }
}
