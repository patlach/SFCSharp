using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SFCS_8._6_WorkWithFiles
{
    public static class FolderSize
    {
        public static long TotalSize(DirectoryInfo di)
        {
            long size = 0;

            FileInfo[] files = di.GetFiles();
            foreach(FileInfo file in files)
            {
                size += file.Length;
            }

            DirectoryInfo[] dirs = di.GetDirectories();
            foreach(DirectoryInfo dir in dirs)
            {
                size += TotalSize(dir);
            }

            return size;

        }
    }
}
