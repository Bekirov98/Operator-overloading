using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload
{
    internal class GroupMate
    {
        private Student[] students = new Student[0];

        public void AddStudent(Student newStudent)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = newStudent;
        }

        public void PrintStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}");
            }
        }

        public void Sort()
        {
            Array.Sort(students, (s1, s2) => s2.Age.CompareTo(s1.Age));
        }
    }
}
