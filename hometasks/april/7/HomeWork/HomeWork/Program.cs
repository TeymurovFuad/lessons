using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                StartPoint:
                Console.WriteLine("Which operation will you do:");
                Console.WriteLine("1 Addition");
                Console.WriteLine("2 Subtraction");
                Console.WriteLine("3 Multiplication");
                Console.WriteLine("4 Division");
                Console.WriteLine("5 Stop");
                string operation = Console.ReadLine();
                if (operation == "5")
                {
                    return;
                }
                Console.WriteLine("Now insert values");
                decimal a = Convert.ToDecimal(Console.ReadLine());
                decimal b = Convert.ToDecimal(Console.ReadLine());
                decimal res = 0;

                //Task 1
                Console.WriteLine("Result using if else");
                if (operation == "1" || operation.ToLower() == "addition")
                {
                    res = a + b;
                }
                else if (operation == "2" || operation.ToLower() == "subtraction")
                {
                    res = a - b;
                }
                else if (operation == "3" || operation.ToLower() == "multiplication")
                {
                    res = a * b;
                }
                else if (operation == "4" || operation.ToLower() == "division")
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Divisor can not be zero or negative number");
                    }
                    res = a / b;
                }
                Console.WriteLine("Result is {0}", res);
                Console.ReadLine();

                //Task 3
                Console.WriteLine("Result using switch case");
                switch (operation)
                {
                    case "1":
                    case "addition":
                        res = a + b;
                        break;
                    case "2":
                    case "subtraction":
                        res = a - b;
                        break;
                    case "3":
                    case "multiplication":
                        res = a * b;
                        break;
                    case "4":
                    case "division":
                        if (b <= 0)
                        {
                            Console.WriteLine("Divisor can not be zero or negative number");
                        }
                        res = a / b;
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        goto StartPoint;
                }
                Console.WriteLine("Result is {0}", res);
                Console.ReadLine();
                goto StartPoint;
            }

            //Task 2
            {
                //const string uName = "Taleh";
                //const string pwd = "1937Aa!";
                //int attempt = 0;
                //bool blocked = false;
                //StartPoint:
                //Console.WriteLine("Please insert username and password");
                //string name = Console.ReadLine();
                //string password = Console.ReadLine();
                //if (!blocked)
                //{
                //    if (name != uName || password != pwd)
                //    {
                //        attempt++;
                //        Console.WriteLine("Wrong credentials inserted. Please try again");
                //        Console.WriteLine("Attempts left -> {0}", 3 - attempt);
                //        if (attempt == 3)
                //        {
                //            blocked = true;
                //            Console.WriteLine("Account blocked");
                //            Console.ReadLine();
                //            return;
                //        }
                //        goto StartPoint;
                //    }
                //    else
                //    {
                //        Console.WriteLine("Success login");
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("Account blocked");
                //}
                //Console.ReadLine();
            }

        }
    }
}
