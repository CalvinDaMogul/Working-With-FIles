using System;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @ "c:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg", @);
            File.Delete(path);
            if (FileStyleUriParser.Exists(path));
            {
                
            }
            
            Console.WriteLine("Hello World!!!");
        }
    }
}