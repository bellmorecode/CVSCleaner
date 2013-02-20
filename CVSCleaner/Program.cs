using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVSCleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a path to clean: ");
            var path = Console.ReadLine();

            path = @"C:\Users\Glenn\Dropbox\CVS_ALL\CLIENTS\";

            var folders = Directory.GetDirectories(path, "CVS", SearchOption.AllDirectories).Where(q => q.EndsWith("CVS"));
            foreach (var folder in folders)
            {
                Console.WriteLine(folder);
                Directory.Delete(folder, true);
            }
            Console.WriteLine("================================");
            Console.WriteLine("Count: {0}", folders.Count());
            Console.WriteLine("================================");
            var final = Console.ReadLine();
        }
    }
}
