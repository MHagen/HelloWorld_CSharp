using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MediaManager
{
    public class FileManagement
    {
        // Folder Exists
            // May not need an explicit method since a "file exists" will prove it's there.
        public static Boolean FolderExists(string folderPath)
        {
            return Directory.Exists(folderPath);
        }


        // File Exists
        // Need to check for specific files - external list?
        // Folder Create
            // May not need, may create if you attempt to copy to it.
        // No Create File

        // Folder Trash

        // File Trash

        // Copy Folder

        // Copy File

    }
}
