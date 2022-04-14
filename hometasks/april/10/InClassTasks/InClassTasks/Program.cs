using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int counter = 0;
            //StartPoint:
            //    Console.WriteLine("#{0} - Salam", counter);
            //    counter++;
            //    if(counter == 100)
            //    {
            //        Console.ReadLine();
            //        return;
            //    }
            //    goto StartPoint;
            //}

            //for (int i = 0; i%2 == 0 && i <= 8; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //string start = "*";
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(new string('*', i));
            //}

            //int sumAll = 0;
            //int sumEven = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    sumAll += i;
            //    if (i % 2 == 0)
            //    {
            //        sumEven += i;
            //    }
            //}
            //Console.WriteLine("sumAll = {0} \nsumEven = {1}", sumAll, sumEven);
            //Console.ReadLine();

            bool exit = false;
            while (!exit)
            {
                string userInput = Console.ReadLine();
                if(userInput == "exit")
                {
                    exit = true;
                }
            }
        }
    }
}
