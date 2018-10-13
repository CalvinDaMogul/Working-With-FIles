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
                //
            }
            var content = File.ReadAllText(path);

            var fileInfo = new Fileinfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
            

            
            Console.WriteLine("Hello World!!!");
        }
    }
}