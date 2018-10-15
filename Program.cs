using System;
using System.IO;
using System.Threading;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\caljf\Pictures\coding3.jpg";

            File.Copy(@"C:\Users\caljf\Pictures\Coding3.jpg", @"C:\Users\caljf\Pictures\test\Coding3.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
          

            
            Console.WriteLine("Hello World!!!");
            Console.WriteLine("Transfer Successful!");
        }
    }
}