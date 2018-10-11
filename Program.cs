using System;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @ "c:\coding3.jpg";

            File.Copy(@"c:\Pictures\Coding3.jpg", @"d:\Pictures\Coding3.jpg", true);
            File.Delete(path);
            if (FileStyleUriParser.Exists(path));
            {

            }
            
            Console.WriteLine("Hello World!!!");
        }
    }
}