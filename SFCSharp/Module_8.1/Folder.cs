using System;
using System.Collections.Generic;
using System.Text;

namespace Module_8._1
{
    public class Folder
    {
        public List<string> Files { get; set; } = new List<string>();

        public Dictionary<string, Folder> Folders { get; set; } = new Dictionary<string, Folder>();

        public void AddFolder(string name)
        {
            Folders.Add(name, new Folder());
        }
    }
}
