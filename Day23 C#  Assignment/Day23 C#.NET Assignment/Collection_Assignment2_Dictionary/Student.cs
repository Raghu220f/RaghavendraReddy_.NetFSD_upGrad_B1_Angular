using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Assignment2_Dictionary
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }

        public Student(int id, string name, double marks)
        {
            Id = id;
            Name = name;
            Marks = marks;
        }
    }
}
