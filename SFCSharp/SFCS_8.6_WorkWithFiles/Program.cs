using System;
using System.IO;

namespace SFCS_8._6_WorkWithFiles
{
    internal class Program
    {
        public static object DirectroyInfo { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter path: ");
            string path = Console.ReadLine();
            DirectoryInfo di = new DirectoryInfo(path);
             
            try
            {
                DeleteFiels.CleanMoreThan30min(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
