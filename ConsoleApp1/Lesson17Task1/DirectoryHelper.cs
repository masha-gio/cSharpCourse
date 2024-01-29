using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17Task1
{
    internal class DirectoryHelper
    {
        public int GetFileCount(string path)
        {
            try
            {
                string[] files = Directory.GetFiles(path);
                return files.Length;
            }
            catch (Exception ex) { 
            Console.WriteLine(ex.ToString());
                return -1;
            }
        }

        public FileInfo[] GetFiles(string path)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                return directoryInfo.GetFiles();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public int GetFileCountByExtension(string path,  string extension)
        {
            try
            {
                string[] files = Directory.GetFiles(path, $"*.{extension}");
                return files.Length;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;
            }
        }

        public FileInfo[] GetFilesByExtension(string path, string extension)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                return directoryInfo.GetFiles($"*.{extension}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
