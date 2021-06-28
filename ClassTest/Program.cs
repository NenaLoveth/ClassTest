using ClassTest.Student.Primary;
using ClassTest.Student.Secondary;
using System;


namespace ClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome!");

          
           /* SStudents student = new SStudents();
            student.CreateStudent();*/

            PStudents Pupil = new PStudents();
            Pupil.CreatePupil();


        }
    }
}
