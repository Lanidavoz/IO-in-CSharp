using System;
using System.IO;
using System.Collections.Generic;

namespace files_module
{
    class Program
    {
        static void Main(string[] args)
        {

            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores", "201", "NewDir"));
            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "greeting.txt"), "Hello World!");

            var currentDirectory = Directory.GetCurrentDirectory();
            var storesDirectory = Path.Combine(currentDirectory, "stores");

            var salesFiles = FindFiles(storesDirectory);

            var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
            Console.WriteLine("salesTotalDir");
            
            Directory.CreateDirectory(salesTotalDir);

            foreach (var file in salesFiles)
            {
                Console.WriteLine(file);
            }
        }

        static IEnumerable<string> FindFiles(string folderName)
        {

            List<string> salesFiles = new List<string>();

            var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

            foreach (var file in foundFiles)
            {
                var extension = Path.GetExtension(file);

                if (extension == ".json")
                    salesFiles.Add(file);
            }

            return salesFiles;
        }
    }
}