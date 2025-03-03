using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public class StudentManager
    {

        public enum Course
        {
            ComputerScience,
            Mathematics,
            Physics,
            Chemistry,
            Biology

        }
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public Course StudentCourse { get; set; }

            public Student(int id, string name, int age, Course course)
            {
                Id = id;
                Name = name;
                Age = age;
                StudentCourse = course;
            }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}, Age: {Age}, Course: {StudentCourse}";
            }
        }
        static List<Student> studentList = new List<Student>();


        static void main()
        {
            while (true)
            {
                Console.WriteLine("==== Student Management System ====");
                Console.WriteLine("Add Student (User Input)");
                Console.WriteLine("2. Add Student (Direct Parameters - Test Mode)");
                Console.WriteLine("3. View All Students");
                Console.WriteLine("4. Search for a Student");
                Console.WriteLine("5. Delete a Student");
                Console.WriteLine("6. Exit");
                Console.WriteLine("select an Id");
            }

            string optionSelect = Console.ReadLine();

            switch (optionSelect)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    DisplayAllStudents();
                    break;
                case "3":
                    SearchStudent();
                    break;
                case "4":
                    DeleteStudent();
                    break;
                default:
                    Console.WriteLine("invalid input");
            }
        }

        static void DeleteStudent()
        {
            throw new NotImplementedException();
        }

        static void SearchStudent()
        {
            throw new NotImplementedException();
        }

        static void DisplayAllStudents()
        {
            throw new NotImplementedException();
        }

        static void AddStudent()
        {
            throw new NotImplementedException();
        }
    }
}
