using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Student
    {
        //Task 2
        double average;

        static void Main(string[] args)
        {
            Student st = new Student();
            st.CalcAvarage(15, 150);
        }

        public double CalcAverage(double grade)
        {
            average = grade;
            return average;
        }

        public double CalcAvarage(double grade, double grade2)
        {
            average = (grade + grade2) / 2;
            return average;
        }

        public double CalcAvarage(double grade, double grade2, double grade3)
        {
            average = (grade + grade2 + grade3) / 3;
            return average;
        }

        public string RateAverage(double average, string surname = "", string name = "")
        {
            string pass = average >= 45 ? "passed" : "did not pass";
            string res = $"{name} {surname}, your average is {average}. You {pass}";
            return res;
        }

    }
}
