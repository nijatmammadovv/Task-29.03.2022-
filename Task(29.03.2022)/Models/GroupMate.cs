using System;
using System.Collections.Generic;
using System.Text;

namespace Task_29._03._2022_.Models
{
    class GroupMate
    {
        Student[] student = new Student[0];

        public Student this[int index]
        {
            get
            {
                return student[index];
            }
            set
            {
                Array.Resize(ref student, student.Length + 1);
                student[index] = value;
            }
        }
        public void Sort()
        {
            if(student.Length > 1)
            {
                for (int i = 0; i < student.Length - 1; i++) ;
            }
        }
        public void NumberofPoint()
        {
            foreach(var Student in student)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
