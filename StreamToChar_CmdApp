using System;
using System.IO;

namespace StreamToCharApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full path of file(.txt): ");
            string path = Console.ReadLine();
            if (File.Exists(path))
            {
                Console.Write("Content(stream):\n"+File.ReadAllText(path));
                
                Console.WriteLine("\n(in chars):");
                using (Stream s = new FileStream(path, FileMode.Open))
                {
                    int read;
                    while((read=s.ReadByte())!=-1)
                    {
                        Console.Write(" {0}", (char)read);
                    }
                }
            }
            else
                Console.WriteLine("File Not Exists");
            Console.Read();
        }
    }
}
