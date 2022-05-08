using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //InClass();
            HomeWork();
        }

        static void InClass()
        {
            Student student = new Student();
            student.DocumentSerial = Console.ReadLine();
            student.DocumentNumber = Console.ReadLine();
            Console.WriteLine(student.DocumentSerial);
            Console.WriteLine(student.DocumentNumber);
            Console.ReadLine();
        }

        static void HomeWork()
        {
            HWStudent student = new HWStudent();
            Console.Write("Student name: ");
            student.FName = Console.ReadLine();
            Console.Write("Student surname: ");
            student.LName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"The mail of this student will be: {student.Mail}");
            Console.ReadLine();

            HWStudent student2 = new HWStudent();
            Console.Write("Student surname: ");
            student2.LName = Console.ReadLine();
            Console.Write("Student name: ");
            student2.FName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"The mail of this student will be: {student2.Mail}");
            Console.ReadLine();
        }
    }
}
