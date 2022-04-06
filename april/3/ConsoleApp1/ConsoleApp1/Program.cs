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

            //int bignum = 5466465;
            //byte iiiToByte2 = (byte)bignum;
            //byte iiiToByte = Convert.ToByte(bignum);


            //Task 1

            int i = 5;
            byte b = 1;
            float f = 5.5F;
            long l = 654644564656;
            short s = 2313;
            string st = "465";
            string st1 = "h";
            char c = '5';

            //Implicit
            long intToLong = i;
            short byteToShort = b;
            double floatToDouble = f;
            float longToFloat = l;
            decimal shortToDecimal = s;

            //Explicit

            short longToShort = (short)l;
            decimal floatToDecimal = (decimal)f;
            byte intToByte = (byte)i;
            int longToInt = (int)l;
            byte floatToByte = (byte)f;

            //Helper

            char stringToChar = Convert.ToChar(st1);
            int stringToInt = Convert.ToInt32(st);
            string intToString = Convert.ToString(b);
            byte charToByte = Convert.ToByte(c);


            //Task 2
            string name, surname, country, city;
            float height, weight;
            decimal salary;
            int age;
            DateTime dateOfBirth;
            bool sex;

            Console.WriteLine("Please enter your");
            Console.WriteLine("Name");
            name = Console.ReadLine();
            Console.WriteLine("Surname");
            surname = Console.ReadLine();
            Console.WriteLine("Sex");
            sex = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Date of birth ex. year/month/day");
            dateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Country");
            country = Console.ReadLine();
            Console.WriteLine("City");
            city = Console.ReadLine();
            Console.WriteLine("Height");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Weight");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Salary ");
            salary = Convert.ToDecimal(Console.ReadLine());

            //Task 3
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your salary");
            salary = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your weight");
            weight = float.Parse(Console.ReadLine());

            int salaryToInt = (int)salary;
            int heightToInt = (int)height;
            int weightToInt = (int)weight;

            byte heightToByte = (byte)heightToInt; //xetasiz
            byte weightToByte = (byte)weightToInt; //xetasiz
            byte salaryToByte = Convert.ToByte(salaryToInt); //xeta cixacaq salary 255-den boyuk olarsa
            byte agteToByte = Convert.ToByte(age); //xeta cixacaq yash 255-den boyuk olarsa
        }
    }
}
