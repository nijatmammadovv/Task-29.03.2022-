using System;
using System.Collections.Generic;
using System.Text;

namespace Task_29._03._2022_.Models
{
    abstract class Person
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }


        static Person()
        {
            _id = 0;
        }
        public Person()
        {
            Id = _id;
            ++_id;
        }

        public abstract string ShowInfo();
    }
}
