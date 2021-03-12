using System;

namespace Pascal
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 1, blank, i, j;
            Console.Write("Enter no.of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Pascal Triangle");
            for(i=0;i<rows;i++)
            {
                for(blank=1;blank<=rows-i;blank++)
                    Console.Write(" "); 
                for (j=0;j<=i;j++)
                {
                    if (j == 0 || i == 0)
                        val = 1;
                    else
                        val = val * (i - j + 1) / j;
                    Console.Write(val + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
