using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SFCS_8._6.BinaryUpload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Write path to .dat file like Disk:\Folder\File.dat");
            string filePath = Console.ReadLine();
            Console.WriteLine(@"Write path to save files (like Disk:\Folder)");
            string saveFilePath = Console.ReadLine() + @"\";

            BinaryFormatter formatter = new BinaryFormatter();

            if (File.Exists(filePath) && Directory.Exists(saveFilePath))
            {
                try
                {
                    using var fs = new FileStream(filePath, FileMode.Open);
                    Student[] Sstudents = (Student[])formatter.Deserialize(fs);
                    foreach (Student student in Sstudents)
                    {
                        FileInfo file = new FileInfo(saveFilePath + student.Group + ".txt");

                        using (StreamWriter sw = file.AppendText())
                        {
                            sw.WriteLine("{0}, {1}", student.Name, student.DateOfBirth);
                        }
                    }

                    Console.WriteLine("Files in folder: {0}", saveFilePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }            
        }
    }
}
