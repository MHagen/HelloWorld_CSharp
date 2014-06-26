using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;


namespace MediaManager
{
    public class FileManagement
    {

        public static Boolean FolderExists(string folderPath)  // Only useful if we need extra checking / set some other value.
        {
            return Directory.Exists(folderPath);
        }


        public static Boolean SingleFileExists(string filePath) // Only useful if we need extra checking / set some other value.
        {
            return File.Exists(filePath);
        }

        // Currently returns the filenames of missing files, but could return other information.
        public static List<string> MultipleFilesExist(string listOfFilesPath) // using a List so I don't need to know how many media files are entered in the text file.
        {
            var mediaList = new List<string>();

            if (SingleFileExists(listOfFilesPath))
            {
                using (var sr = new StreamReader(listOfFilesPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string mediafile = sr.ReadLine();

                        if (!SingleFileExists(mediafile))
                        {
                            mediaList.Add(Path.GetFileName(mediafile) + " was not found.");
                        }
                        
                    }

                }

            }

                return mediaList;

        }


        public static Boolean CreateFolder(string folderPath, string folderName) // Divided the path and name for flexibility later on.
        {

            string newFolder = Path.Combine(folderPath, folderName);

            if (!FolderExists(newFolder))
            {
                try
                {
                    Directory.CreateDirectory(newFolder);
                }
                catch (Exception ex) // Should alter this to log an error and to handle specific exceptions.
                {
                    Debug.Print(ex.Message);
                }

            }
                return FolderExists(newFolder); 
        }



        // Folder Trash - requires a reference to VB!?

        public static Boolean MoveFolderToTrash(string folderPath, string folderName)
        {
            string newFolder = Path.Combine(folderPath, folderName);
            if (FolderExists(newFolder))
            {
                FileSystem.DeleteDirectory(newFolder, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
            }
            
            return FolderExists(newFolder);
        }


        // File Trash

        // Copy Folder

        // Copy File

    }
}
