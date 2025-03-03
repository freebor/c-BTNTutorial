using System;
using System.Collections.Generic;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            var displayStudentInfo = new DisplayStudentInfo();
            displayStudentInfo.Run();

            Console.ReadKey();
        }
        public enum Course
        {
            ComputerScience,
            Mathematics,
            Physics,
            Chemistry,
            Biology
        }

        public class DisplayStudentInfo
        {
            public void Run()
            {
                bool isTrue = true;
                do
                {
                    Console.WriteLine("==== Student Management System ====");
                    Console.WriteLine("1. Add Student (User Input)");
                    Console.WriteLine("2. View All Students");
                    Console.WriteLine("3. Search for a Student");
                    Console.WriteLine("4. Delete a Student");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("select an Id:");


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
                        case "5":
                            isTrue = false;
                            Console.WriteLine("Exiting.......");
                            break;
                        default:
                            Console.WriteLine("invalid input");
                            break;
                    }
                } while (isTrue);
            }
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
        static void DeleteStudent()
        {
            Console.Write("Enter student Id to delete:");
            if(!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("please input a valid Id");
            }

            var student = studentList.Find(x => x.Id == id);
            if (student != null)
            {
                studentList.Remove(student);
                Console.WriteLine("a student has been removed");
            }
        }

        static void SearchStudent()
        {
            Console.WriteLine("Enter a valid Id to search:");
            if(!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid Id..");
            }

            var searchStudent = studentList.Find(s => s.Id == id);

            if (searchStudent != null) 
            {
                Console.WriteLine(searchStudent);
            }
        }

        static void DisplayAllStudents()
        {
            if (studentList.Count == 0) 
            {
                Console.WriteLine("There is no registered student");
            }

            Console.WriteLine("total List of Student");
            foreach (Student student in studentList)
            {
                Console.WriteLine(student);
            }
        }

        static void AddStudent()
        {
            bool isTrue = true;
            //To Input student Id 
            Console.Write("Please Enter Student Id :");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                isTrue = true;
                Console.WriteLine("Invalid ID format, Must be a number");
            }

            //To Input student Name 
            Console.Write("Please Enter Student Name :");
            string studentName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(studentName))
            {

                Console.WriteLine("student name cannot be empty");
            }

            //To Input student Age 
            Console.Write("Please Enter Student Age :");
            if (!int.TryParse(Console.ReadLine(), out int Age))
            {
                Console.WriteLine("Invalid ID format, Must be a number");
            }

            //To Input student course 
            Console.Write("Here are the List of Available Courses :");
            // Display course options
            Console.WriteLine("\nSelect a Course:");
            foreach (var course in Enum.GetValues(typeof(Course)))
            {
                Console.WriteLine($"{(int)course}. {course}");
            }

            Console.Write("Enter Course Number: ");
            if (!int.TryParse(Console.ReadLine(), out int courseChoice) || !Enum.IsDefined(typeof(Course), courseChoice))
            {
                Console.WriteLine("Invalid course selection.");
                return;
            }

            Course selectedCourse = (Course)courseChoice;

            studentList.Add(new Student(id, studentName, Age, selectedCourse));
        }
    }

}
