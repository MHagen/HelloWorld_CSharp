using System;
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
    }
}
