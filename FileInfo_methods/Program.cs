using System;
using System.IO;

namespace FileInfo_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates reference to a file
            FileInfo fi=new FileInfo("test.txt");
            
            //creating a file
            //FileStream fs = fi.Create(); OR
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fs);
            Console.Write("\nContent: " + sr.ReadToEnd());
            sw.Write("\nIm the content\nexcuse"+ fi.GetHashCode());
            
            fi.Encrypt();
            Console.Write("\nContent: " + sr.ReadToEnd());//doesn't prints content
            

            sw.Close();
            sr.Close();
            fs.Close();
            //FileInfo fi = new FileInfo("C:\\Users\\Sanjay-PC\\source\\repos\\Sanjay_C#_Lab\\FileInfo_Methods\\FileInfo_Methods\\test.txt");
            
            Console.WriteLine("\nProperties:\nDirectoryName : " + fi.DirectoryName + "\nFullName: " + fi.FullName + "\nExtension: " + fi.Extension+"\nSize(Length):"+fi.Length+"\nName:"+fi.Name+"\nIsReadOnly:"+fi.IsReadOnly+"\nLastWriteTime:"+fi.LastWriteTime+ "\nLastAccessTime: "+fi.LastAccessTime+"\nExists: "+ fi.Exists);
            
            Console.Read();
        }
    }
}
