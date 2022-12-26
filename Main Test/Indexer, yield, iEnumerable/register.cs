using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Test.Indexer__yield__iEnumerable
{
    class register : IEnumerable
    {
        private List<Student> Students = new List<Student>();
        private const int MAX_STUDENTS = 100;
        public int StudCount => Students.Count;

        //Indexer
        public Student this[string name]
        {
            get 
            { 
                var student = Students.FirstOrDefault(s => s.Name == name);
                return student;
            }
        }
        public void AddStudents(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "The student does not exist.");
            }
            if (Students.Count() < MAX_STUDENTS)
            {
                Students.Add(student);
            }
        }
        
        public void GoOut(int id)
        {
            var student = Students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                Students.Remove(student);
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
