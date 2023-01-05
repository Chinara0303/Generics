using Generics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class StudentList
    {
        private Student[] _students;
        public StudentList()
        {
            _students = new Student[0];
        }

        public void Add(Student student)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = student;
        }

        public void GetAll()
        {
            foreach (var item in _students)
            {
                Console.WriteLine($"{item.Name} {item.Surname}");
            }
        }
    }
}
