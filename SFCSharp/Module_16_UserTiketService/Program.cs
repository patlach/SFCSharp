using System;
using System.IO;

namespace Module_16_UserTiketService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var imagePath = @"C:\Users\epolushin\Desktop\AnniversaryWork\happy_anniversary_default.png";

            var s = ImageToBinary(imagePath);

            var i = Convert.ToHexString(s);

            Console.WriteLine(imagePath);
            Console.WriteLine("0x"+i);

            Console.ReadLine();

        }

        public static byte[] ImageToBinary(string imagePath)
        {
            FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fileStream.Length];
            fileStream.Read(buffer, 0, (int)fileStream.Length);
            fileStream.Close();
            return buffer;
        }
    }
}
