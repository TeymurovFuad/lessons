using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        //Task 1
        static void Main(string[] args)
        {
            var cl = new Task1();
            Console.WriteLine(cl.ClassA());

            
        }

        //Task 3
        public void Calculator(string _operator)
        {
            string op = _operator;
            double Add(double a, double b)
            {
                return a+b;
            }

            double Subtract(double a, double b)
            {
                return a - b;
            }   

            //int Subtract(int a, int b)
            //{
            //    return a - b;
            //}

            double Multiply(double a, double b)
            {

                return a * b;
            }

            double Divide(double a, double b)
            {
                if (b == 0)
                    throw new DivideByZeroException("Divider can not be zero");
                return a / b;
            }
        }

        //Task 4
        string className;
        string teacherName;
        string student1;
        string student2;
        string student3;
        string student4;
        string student5;
        string student6;
        string student7;
        string student8;
        string student9;
        string student10;

        public void ClassName()
        {
            Console.Write("Please write class name: ");
            className = Console.ReadLine();
        }

        public void TeacherName()
        {
            Console.Write("Please write teacher name: ");
            teacherName = Console.ReadLine();
        }

        public void StudentName()
        {
            Console.WriteLine("Please insert stundents name");
            Console.Write("#1 student: ");
            student1 = Console.ReadLine();
            Console.Write("#2 student: ");
            student2 = Console.ReadLine();
            Console.Write("#3 student: ");
            student3 = Console.ReadLine();
            Console.Write("#4 student: ");
            student4 = Console.ReadLine();
            Console.Write("#5 student: ");
            student5 = Console.ReadLine();
            Console.Write("#6 student: ");
            student6 = Console.ReadLine();
            Console.Write("#7 student: ");
            student7 = Console.ReadLine();
            Console.Write("#8 student: ");
            student8 = Console.ReadLine();
            Console.Write("#9 student: ");
            student9 = Console.ReadLine();
            Console.Write("#10 student: ");
            student10 = Console.ReadLine();
        }

        static void DisplayClassData(string cname, string tname, params string[] students)
        {
            Console.WriteLine($"The name of class is: {cname}");
            Console.WriteLine($"The name of teacher is: {tname}");
            int i = 1;
            foreach(string student in students)
            {
                Console.WriteLine($"Student #{i}: {student}");
            }
            Console.ReadLine();
        }
        
    }
}
