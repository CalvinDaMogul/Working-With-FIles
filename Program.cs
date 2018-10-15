using System;
using System.IO;
using System.Threading;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\caljf\Pictures\Cigar1.jpg";

            File.Copy(@"C:\Users\caljf\Pictures\Cigar1.jpg", @"C:\Users\caljf\Pictures\test\Cigar1.jpg", true);
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