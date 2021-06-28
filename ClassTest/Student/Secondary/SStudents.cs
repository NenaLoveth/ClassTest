using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest.Student.Secondary
{
    public class SStudents
    {
        StudentServices StudentServices;
        SClassEnum Class;

        public SStudents()
        {
            StudentServices = new StudentServices();
        }
        public void CreateStudent()
        {
            StudentModel student = new StudentModel();

            student = StudentServices.RegisterStudent();

            Console.WriteLine("Enter Secondary class 1,2,3,4,5,6");
            Class = (SClassEnum)Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\t\t***Summary***");

            Console.WriteLine($"Name: {student.Name}");

            Console.WriteLine($"Age: {student.Age}");

            Console.WriteLine($"Class: {Class}");

            Console.WriteLine($"Term: {student.Term}");

            Console.WriteLine($"Fees: {student.Fees}");







        }
    }
}
