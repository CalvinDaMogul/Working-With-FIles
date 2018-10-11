using System;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @ "c:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg", @);
            
            Console.WriteLine("Hello World!!!");
        }
    }
}