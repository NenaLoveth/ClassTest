using System;

namespace ClassTest.Student
{
    public class StudentServices
    {
        public StudentModel RegisterStudent()
        {
            StudentModel student = new StudentModel();

            Console.WriteLine("Enter Name:");
            student.Name = Console.ReadLine();

            Console.WriteLine("Enter Age:");
            student.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter fees amount:");
            student.Fees = Convert.ToInt32(Console.ReadLine());  
            
            Console.WriteLine("Enter Term 1,2,3");
            student.Term = (TermEnum) Convert.ToInt32(Console.ReadLine());
            return student;
        }
    }
}
