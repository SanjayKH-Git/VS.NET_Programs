using System;
using System.Net;
namespace IPAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = Dns.GetHostName();
            Console.WriteLine("Host: "+host);
            foreach (var ip in Dns.GetHostEntry(host).AddressList)                
                    Console.WriteLine(ip.AddressFamily+" : "+ip);
            Console.Read();
        }
    }
}
