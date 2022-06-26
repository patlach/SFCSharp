using System;
using System.Collections.Generic;
using System.Text;

namespace SFCS_8._6.BinaryUpload
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public string DateOfBirth { get; set; }

        public Student(string name, string group, string dateofbirth)
        {
            Name = name;
            Group = group;
            DateOfBirth = dateofbirth;
        }
    }
}
