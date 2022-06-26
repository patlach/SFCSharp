using SFCS_8._6.BinaryUpload;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SFCS_8._6_BinaryFileCreateStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Temp\students.dat";

            Student[] students = { new Student("Егор", "301", "01.01.2000"),
                                   new Student("Иван", "301-A", "01.07.2000"),
                                   new Student("Федор", "301-B", "05.06.2000"),
                                   new Student("Петр", "302", "01.04.2000"),
                                   new Student("Дюша", "302", "01.03.2000"),
                                   new Student("Стас", "301", "01.02.2000")
                                   };

            BinaryFormatter formatter = new BinaryFormatter();

            using (var fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, students);
                Console.WriteLine("File serialize");
            }
        }
    }
}
