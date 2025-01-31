using System;
using System.Data.Entity;

namespace StudentDatabaseApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the stundet register. Press enter to register a new student");
            Console.WriteLine("Enter the student's first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter the student's email address");
            string emailaddress = Console.ReadLine();
            Console.WriteLine("Enter the student's current GPA");
            double GPA = Convert.ToDouble(Console.ReadLine());


            using (var context  = new StudentContext())
            {
                var student = new Student()
                {
                    StudentFirstName = firstname,
                    StudentLastName = lastname,
                    StudenEmailAddress = emailaddress,
                    StudenGPA = GPA
                };
                context.Students.Add(student);
                context.SaveChanges();
            }
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string StudenEmailAddress { get; set; }
        public double StudenGPA { get; set; }
    }

    public class StudentContext : DbContext
    {
        public StudentContext() : base() {}
        public DbSet<Student> Students { get; set; }
    }
}
