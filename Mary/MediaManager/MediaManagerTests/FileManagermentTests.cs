using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaManager;

namespace MediaManagerTests
{
    [TestClass]
    public class FileManagermentTests
    {
        [TestMethod]
        public void FolderDoesNotExist()
        {

            Assert.AreEqual(false, FileManagement.FolderExists(@"C:\wrong"));

        }

        [TestMethod]
        public void FolderExists()
        {
            Assert.AreEqual(true,FileManagement.FolderExists(@"C:\Users"));
        }

        [TestMethod]
        public void FileExists()
        {
            Assert.AreEqual(true, FileManagement.SingleFileExists(@"C:\Users\v-masloa\Desktop\m.youtube.xlsx"));  // this a bad test as I'm using a file no one else can get to.
        }

        [TestMethod]
        public void FileDoesntExists()
        {
            Assert.AreEqual(false, FileManagement.SingleFileExists(@"C:\Users\v-masloa\Desktop\wrong.exe"));  // this a bad test as I'm using a file no one else can get to.
        }


        [TestMethod]
        public void MultipeFilesExist()
        {
            // need to compare the data in the list with known values.
            // pass it a new text file with known values and have each on
            const string defaultMediaFiles = "DefaultMediaFile.txt";

            List<string> results = FileManagement.MultipleFilesExist(defaultMediaFiles);

            foreach (var result in results)
            {
                Assert.AreEqual("Blah.txt was not found.", FileManagement.MultipleFilesExist(defaultMediaFiles) );
            }

        }
    }
}
