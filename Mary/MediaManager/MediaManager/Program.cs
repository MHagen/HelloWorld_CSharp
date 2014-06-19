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

            var FolderPath = @"C:\Users";
            Console.WriteLine("Folder " + FolderPath + " is " + FileManagement.FolderExists(FolderPath));
            Console.ReadLine();
        }
    }
}
