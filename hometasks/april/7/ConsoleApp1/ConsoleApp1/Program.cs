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
            //    Console.WriteLine("Please insert your exam result");
            //    float result = float.Parse(Console.ReadLine());

            //    if (result >= 0 && result <= 100)
            //    {
            //        if (result < 20)
            //        {
            //            Console.WriteLine("Failed");
            //        }
            //        else if (result < 40)
            //        {
            //            Console.WriteLine("Passed");
            //            Console.WriteLine("Qənaətbəxş");
            //        }
            //        else if (result < 60)
            //        {
            //            Console.WriteLine("Passed");
            //            Console.WriteLine("Kafi");
            //        }
            //        else if (result < 80)
            //        {
            //            Console.WriteLine("Passed");
            //            Console.WriteLine("Yaxşı");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Pefecto");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong input");
            //    }

            //    Console.ReadLine();
            int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
    }

}
}
