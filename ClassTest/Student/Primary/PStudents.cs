using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest.Student.Primary
{
    public class PStudents
    {
        StudentServices StudentServices;
        ClassEnum PClass;
        public PStudents()
        {
            StudentServices = new StudentServices();
        }

        public void CreatePupil()
        {
            StudentModel Pupil = new StudentModel();
            Pupil = StudentServices.RegisterStudent();

            Console.WriteLine("Enter primary class 1,2,3,4,5,6");
            PClass = (ClassEnum)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\t\t***Summary***");

            Console.WriteLine($"Name: {Pupil.Name}");

            Console.WriteLine($"Age: {Pupil.Age}");

            Console.WriteLine($"Class: {PClass}");

            Console.WriteLine($"Term: {Pupil.Term}");

            Console.WriteLine($"Fees: {Pupil.Fees}");


        }



    }



    
}
