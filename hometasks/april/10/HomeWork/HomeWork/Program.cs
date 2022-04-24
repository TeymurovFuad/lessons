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
            //Task 1
            Console.WriteLine("Insert any positive number. To complete and see result insert negative number");
            decimal userInput = Convert.ToDecimal(Console.ReadLine());
            decimal res = 0;
            while (userInput >= 0)
            {
                res += userInput;
                userInput = Convert.ToDecimal(Console.ReadLine());
            };
            Console.WriteLine("Result is {0}", res);
            Console.ReadLine();


            //Task 2
            Console.Clear();
            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("{0}x{1}={2}\t", i, j, i*j);
                }
                Console.WriteLine("\n----------------------------------------------------------------------------");
            }

            //Task 3
            Console.Clear();
            Console.WriteLine("To start game, please, insert any number greater than 1");
            Random r = new Random();
            int userInput3 = Convert.ToInt32(Console.ReadLine());
            decimal randInt = r.Next(1, userInput3);
            Console.WriteLine("Please find randomly generated number between 1 and {0} (max attempts: 5)", userInput3);
            int attemt = 1;
            int guess;
            while(true)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (attemt == 5)
                {
                    Console.WriteLine("No attempts left. You are oficially looser");
                    break;
                }
                else if(guess == randInt)
                {
                    Console.WriteLine("Right guess from {0}. attempt", attemt);
                    break;
                }
                else if(guess != randInt)
                {
                    Console.WriteLine("Wrong guess. Attemt: {0}", attemt);
                    attemt++;
                    continue;
                }
            }
            Console.ReadLine();

            //Task 4
            Console.Clear();
            Console.WriteLine("Insert any number");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            while(userInput2 != 0)
            {
                userInput2--;
                Console.WriteLine(userInput2);
            }
            Console.ReadLine();
        }
    }
}
