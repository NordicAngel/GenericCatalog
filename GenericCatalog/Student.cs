using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCatalog
{
    class Student
    {
        private static int _nextId = 1;
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(string name)
        {
            Id = _nextId++;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, is named {Name}";
        }
    }
}
