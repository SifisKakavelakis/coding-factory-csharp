using System;
using System.Collections.Generic;
using System.Text;

namespace LinqApp
{
    internal class Student : IComparable<Student>
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int Age { get; set; }

        public int CompareTo(Student? other)
        {
            return string.Compare(Lastname, other?.Lastname, StringComparison.OrdinalIgnoreCase);   // null safe
        }
    }
}
