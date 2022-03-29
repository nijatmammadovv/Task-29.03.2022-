using System;
using System.Collections.Generic;
using System.Text;

namespace Task_29._03._2022_.Models
{
    class Teacher:Person
    {
        public double Salary { get; set; }

        public Teacher(string name,string surname,int age,double salary)
        {
            Name = name;
            Surname = surname;
            Age=age;
            Salary = salary;
        }

        public Teacher(string name, string surname, double salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }

        public override string ShowInfo()
        {
            return ($"Id:{Id}\n" +
                $"Name:{Name}\n" +
                $"Surname:{Surname}\n" +
                $"Age:{Age}\n" +
                $"Salary:{Salary}");
        }
        public override string ToString()
        {
            return ShowInfo();
        }
        public static bool operator > (Teacher teacher1,Teacher teacher2)
        {
            if (teacher1.Salary > teacher2.Salary)
                return true;
            else
            {
                return false;
            }
        }
        public static bool operator < (Teacher teacher1, Teacher teacher2)
        {
            if (teacher1.Salary < teacher2.Salary)
                return true;
            else
            {
                return false;
            }
        }
    }
}
