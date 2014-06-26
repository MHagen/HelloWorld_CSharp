using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    class Program
    {
        static void Main(string[] args)
        {

            var folderPath = Environment.SpecialFolder.MyDocuments.ToString();
            var folderName = "MediaTestFolder";
            // var folderPath = @"C:\Users";
            const string defaultMediaFiles = "DefaultMediaFile.txt";

            List<string> results = FileManagement.MultipleFilesExist(defaultMediaFiles);
            foreach (var result in results )
            {
               Console.WriteLine(result);
            }

            Console.WriteLine("Media folder exists? " + FileManagement.CreateFolder(folderPath, folderName));
            Console.ReadLine();
            Console.WriteLine("Folder exists? " + FileManagement.MoveFolderToTrash(folderPath, folderName));
            Console.ReadLine();
        }
    }
}
