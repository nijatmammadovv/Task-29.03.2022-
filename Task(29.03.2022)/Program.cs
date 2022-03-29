using System;
using Task_29._03._2022_.Models;

namespace Task_29._03._2022_
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] student1 = new Student[0];
            Person[] teacher1 = new Teacher[0];
            string Name = " ";
            string Surname = " ";
            int Age = 0;
            double Salary = 5;
            double Point = 85;

            int choice = 0;
            do
            {
                Console.WriteLine("Choose the command (0:Info)");
                Console.WriteLine("--------------");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("--------------------");
                        Console.WriteLine("1.Create a document about the student\n" +
                            "2.Create a document about the teacher\n" +
                            "3.End");
                        Console.WriteLine("--------------------");
                        break;
                    case 1:
                        Console.WriteLine("--------------------");
                        EnterStudentİnformation(ref Name, ref Surname, Age,ref Point);
                        Student student = new Student(Name, Surname, Point);
                        Array.Resize(ref student1, student1.Length + 1);
                        student1[student1.Length - 1] = new Student(Name, Surname, Point);
                        Console.WriteLine("--------------------");
                        break;
                    case 2:
                        Console.WriteLine("--------------------");
                        EnterTeacherİnformation(ref Name, ref Surname, ref Age, ref Salary);
                        Teacher teacher = new Teacher(Name, Surname, Salary);
                        Array.Resize(ref teacher1, teacher1.Length + 1);
                        teacher1[teacher1.Length - 1] = new Teacher(Name, Surname, Salary);
                        Console.WriteLine("--------------------");
                        break;
                    case 3:
                        Console.WriteLine("--------------------");
                        Console.WriteLine("End");
                        Console.WriteLine("--------------------");
                        break;
                    default:
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Information about this teacher or student was entered incorrectly.");
                        Console.WriteLine("--------------------");
                        break;
                }
            } while (choice != 3);
        }
        static void EnterStudentİnformation( ref string Name,ref string Surname,int Age, ref double Point)
        {
            StudentTeacherName(ref Name);
            StudentTeacherSurname(ref Surname);
            AgeLimitOfStudent(Age);
            CheckPoint(ref Point);
            
        }
        static void EnterTeacherİnformation(ref string Name, ref string Surname, ref int Age, ref double Salary)
        {
            StudentTeacherName(ref Name);
            StudentTeacherSurname(ref Surname);
            AgeLimitOfTheTeacher(ref Age);
            TeacherSalary(ref Salary);

        }

        static void StudentTeacherName(ref string Name)
            {
                Begin:
                try
                {
                    Console.WriteLine("Enter the person's name");
                    Name = Convert.ToString(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Begin;
                }
            }
        static void StudentTeacherSurname(ref string Surname)
        {
            Initiate:
            try
            {
                Console.WriteLine("Enter the person's last name");
                Surname = Convert.ToString(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Initiate;
            }
        }
        static void AgeLimitOfStudent(int Age)
        {
            GetStarted:
            try
            {
                Console.WriteLine("Enter age");
                Age = Convert.ToInt32(Console.ReadLine());
                if (Age < 6 || Age > 20)
                {
                    Console.WriteLine("This person is not a student.");
                }
                else if (Age > 6 || Age < 20)
                {
                    Console.WriteLine("You can enter information about the student.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto GetStarted;
            }
        }
        static void CheckPoint(ref double Point)
        {
            GetBegin:
            try
            {
                Console.WriteLine("Write the student's points");
                Point = Convert.ToDouble(Console.ReadLine());
                if (Point > 0 || Point <= 100)
                {
                    Console.WriteLine("The student scored a certain number of points in the exam.");
                }
                else if (Point > 100 || Point < 0)
                {
                    Console.WriteLine("There is no such scale.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto GetBegin;
            }
        }
        static void AgeLimitOfTheTeacher(ref int Age)
        {
            Commence:
            try
            {
                Console.WriteLine("Enter age");
                Age = Convert.ToInt32(Console.ReadLine());
                if (Age < 18 || Age > 65)
                {
                    Console.WriteLine("This person cannot work as a teacher");
                }
                else if (Age > 18 || Age <= 65)
                {
                    Console.WriteLine("This person has the right to work as a teacher.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Commence;
            }
        }
        static void TeacherSalary(ref double Salary)
        {
            GetBegining:
            try
            {
                Console.WriteLine("-------------");
                Console.WriteLine("Enter the salary");
                Salary = Convert.ToDouble(Console.ReadLine());
                if (Salary < 0)
                {
                    Console.WriteLine("This teacher has no salary");
                }
                else if (Salary > 0)
                {
                    Console.WriteLine("This teacher can get a certain amount of salary.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto GetBegining;
            }
        }
    }
}
