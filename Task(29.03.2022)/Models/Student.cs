using System;
using System.Collections.Generic;
using System.Text;

namespace Task_29._03._2022_.Models
{
   internal class Student:Person
    {
        public double Point { get; set; }

        public Student(string name,string surname,double point) : base()
        {
            Name = name;
            Surname = surname;
            Point = point;
        }

        public override string ShowInfo()
        {
            return ($"Id:{Id}\n" +
                $"Name:{Name}\n" +
                $"Surname:{Surname}\n" +
                $"Age:{Age}\n" +
                $"Point:{Point}");
        }
        public override string ToString()
        {
            return ShowInfo();
        }
        public void CheckPoint(double point)
        {
            Start:
            try
            {
                point = Convert.ToDouble(Console.ReadLine());
                if (point > 100 || point < 0)
                {
                    Console.WriteLine("There is no such scale.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        public static bool operator > (Student student1,Student student2)
        {
            if (student1.Point > student2.Point)
                return true;
            else
            {
                return false;
            }                
        }
        public static bool operator < (Student student1, Student student2)
        {
            if (student1.Point < student2.Point)
                return true;
            else
            {
                return false;
            }
        }
    }
}
