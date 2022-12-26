using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Test.Indexer__yield__iEnumerable
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public int[] Rating { get; set; }
        public Student(int id, string name, string group, int[] rating)
        {
            Id = id;
            Name = name;
            Group = group;
            Rating = rating;
        }
    }
}
