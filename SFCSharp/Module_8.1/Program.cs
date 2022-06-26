using System;
using System.IO;

namespace Module_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeleteDir();

            //AddDir();

            //DriveInfo[] d = DriveInfo.GetDrives();

            //foreach (DriveInfo dd in d)
            //{
            //    Console.WriteLine("Name: {0}", dd);
            //    Console.WriteLine("Type: {0}", dd.DriveType);
            //    if (dd.IsReady)
            //    {
            //        Console.WriteLine("Size: {0}", dd.TotalSize);
            //        Console.WriteLine("Free space: {0}", dd.TotalFreeSpace);
            //        Console.WriteLine("Volume label: {0}", dd.VolumeLabel);
            //    }
            //}

            //GetCatalogs();

            //TotalDirsAndFiles();
        }

        static void GetCatalogs()
        {
            string dirName = @"C:\";
            if (Directory.Exists(dirName)) ;
            {
                Console.WriteLine("Folder");
                string[] dirs = Directory.GetDirectories(dirName);

                foreach(string dir in dirs)
                {
                    Console.WriteLine(dir);
                }

                Console.WriteLine("Total dirs: {0}", dirs.Length);

                Console.WriteLine("\nFiles");
                string[] files = Directory.GetFiles(dirName);

                foreach(string file in files)
                {
                    Console.WriteLine(file);
                }

                Console.WriteLine("Total files: {0}", files.Length);
            }
        }

        static void TotalDirsAndFiles()
        {
            string dirName = @"A:\";

            if (Directory.Exists(dirName))
            {
                string[] dirs = Directory.GetDirectories(dirName);
                string[] files = Directory.GetFiles(dirName);

                Console.WriteLine();
                Console.WriteLine("Total dirs: {0}", dirs.Length);
                Console.WriteLine("Total files: {0}", files.Length);
            }
            else
            {
                Console.WriteLine("directory does not exist");
            }
        }

        static void AddDir()
        {
            DirectoryInfo newDirectory = new DirectoryInfo(@"C:/newDirectoryy");

            if (!newDirectory.Exists)
            {
                newDirectory.Create();
                Console.WriteLine("New folder {0} create", newDirectory.Name);
            }

        }

        static void DeleteDir()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:/newDirectory");

            dir.Delete();

            Console.WriteLine("Folder {0} deleted", dir.Name);

        }
    }
}
