using System;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] src = { 15, 67, 89, 90,180,270 };
            int[] dest=new int[3];
            Array.Copy(src, dest, 3);
            Console.Write("Source_Array= ");
            foreach (int e in src)
                Console.Write(e+" ");
            Console.Write("\nDest_Array= ");
            foreach (int e in dest)
                Console.Write(e+" ");
        }
    }
}
