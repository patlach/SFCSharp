using System;
using System.IO;

namespace Module_8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteValues();
            ReadValues();
            //string filePath = @"C:\SFCS\SFCSharp\Module_8.3\Program.cs";

            //FileInfo file = new FileInfo(filePath);

            //if (File.Exists(filePath))
            //{
            //    using (StreamWriter sw = file.AppendText())
            //    {
            //        sw.WriteLine("//Open time: {0}", DateTime.Now.ToString());
            //    }
            //    using (StreamReader sr = new StreamReader(filePath))
            //    {
                    
            //        string line = "";
            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
        }

        static void WriteValues()
        {
            string filePath = @"C:\Temp\BinaryFile.bin";
            using (BinaryWriter wr = new BinaryWriter(File.Open(filePath, FileMode.)))
            {
                wr.Write($"Файл изменен {DateTime.Now} на компьютере с ОС {Environment.OSVersion}");
            }
        }

        static void ReadValues()
        {
            string filePath = @"C:\Temp\BinaryFile.bin";
            string Date;
            string Name;

            using (BinaryReader br = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                Date = br.ReadString();
            }

            Console.WriteLine(Date);
        }

    }
}
//Open time: 25.06.2022 14:37:37
//Open time: 25.06.2022 14:37:42
