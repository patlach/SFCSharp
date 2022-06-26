using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SFCS_8._6_WorkWithFiles
{
    public static class DeleteFiels
    {
        public static void CleanMoreThan30min(string path)
        {
            var dirs = new DirectoryInfo(path);
            var dirSize = FolderSize.TotalSize(dirs);

            Console.WriteLine("Folder size: {0}", dirSize);

            foreach (FileInfo file in dirs.GetFiles())
            {
                if ((DateTime.Now - file.LastWriteTime) > TimeSpan.FromMinutes(30))
                {
                    Console.WriteLine("File {0} was delete", file.Name);
                    file.Delete();
                }
            }

            foreach (DirectoryInfo dir in dirs.GetDirectories())
            {
                if ((DateTime.Now - dir.LastWriteTime) > TimeSpan.FromMinutes(30))
                {
                    Console.WriteLine("Folder {0} was delete", dir.Name);
                    dir.Delete(true);
                }
            }

            var deletedSize = FolderSize.TotalSize(dirs); 

            Console.WriteLine("Deleted size: {0}", dirSize - deletedSize);
            Console.WriteLine("Folder size after delete: {0}", deletedSize);         
        }
    }
}
