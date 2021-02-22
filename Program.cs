using System;
using System.IO;
using System.Collections.Generic;

namespace files_module
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = FindFiles("stores");

            Console.WriteLine(Directory.GetCurrentDirectory());

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

              var currentDirectory = Directory.GetCurrentDirectory();

              var salesFiles = FindFiles("stores");

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
                if (file.EndsWith("sales.json"))
                {
                    salesFiles.Add(file);
                }
            }

            return salesFiles;
        }
    }
}
