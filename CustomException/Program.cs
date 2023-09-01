using System;
using System.Text.RegularExpressions;

namespace CustomException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = null;

            try
            {
                newStudent = new Student();
                newStudent.StudentName = "Vamshi11";

                ValidateStudent(newStudent);
            }
            catch (InvalidStudentNameException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        public static void ValidateStudent(Student std)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(std.StudentName))
                throw new InvalidStudentNameException(std.StudentName);
            else
                Console.WriteLine(std.StudentName);
        }
    }
}
