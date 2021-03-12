using System;
using System.IO;

namespace DelegateFile
{
    class Program
    {
        static FileStream fs;
        static StreamWriter sw;
        public delegate void printString(string s);
        public static void screen(string str)
        {
            Console.WriteLine("The string is:{0}",str);
        }
        public static void File(string s)
        {
            fs = new FileStream("C:\\Users\\User\\source\\repos\\Sanjay_c#_Lab\\DelegateFile\\DelegateFile\\Msg.txt",FileMode.Append,FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public static void sendString(printString ps)
        {
            ps("C# Program to \nuse Delegates");
        }
        static void Main(string[] args)
        {
            printString ps1 = new printString(screen);
            printString ps2 = new printString(File);
            sendString(ps1);
            sendString(ps2);
        }
    }
}
