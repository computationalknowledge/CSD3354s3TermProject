using System;

namespace ArraysPlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class PlayingWithArrays
    {

        public void Run()
        {
           
            Student[] students = new Student[10];

            students[0] = new Student("John", "101");
            students[1] = new Student("Mary", "102");
            students[2] = new Student("Susan", "103");
        }

    }

    class Student
    {
        public Student(string name, String id)
        {
            this.StudentName = name;
            this.StudentID = id;
        }

        public String StudentName;
        public String StudentID;
        

    }
}
