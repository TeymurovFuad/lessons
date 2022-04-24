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
            //{
            //    Console.WriteLine("How many students in a class ?");
            //    int totalStudents = Convert.ToInt32(Console.ReadLine());
            //    //string[] studentsName = new string[totalStudents > 0? totalStudents:0];
            //    string[] nameArray = new string[totalStudents];
            //    byte[] ageArray = new byte[totalStudents];
            //    string name;
            //    byte age;
            //    if (totalStudents <= 0)
            //    {
            //        Console.WriteLine("Total number of students less than or equal to 0");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Insert name and age of students");
            //        foreach(int i in Enumerable.Range(1, totalStudents))
            //        {
            //            Console.WriteLine("\tThe name of {0}. student:", i);
            //            name = Console.ReadLine();
            //            nameArray[i - 1] = name;
            //            Console.WriteLine("\tThe age of {0}. student:", i);
            //            age = Convert.ToByte(Console.ReadLine());
            //            ageArray[i - 1] = age;
            //            Console.Clear();
            //        }

            //        Console.WriteLine("List of students:");
            //        for(int j = 0; j < totalStudents; j++)
            //        {
            //            Console.WriteLine("\t{0}: {1} is {2} years old", j, nameArray[j], ageArray[j]);
            //        }
            //    }
            //    Console.ReadLine();
            //}

            //Task 2
            //{
            //    Console.WriteLine("Please insert expected length of an array:");
            //    int len = Convert.ToInt32(Console.ReadLine());
            //    decimal[] numbers = new decimal[len];
            //    decimal num;
            //    decimal sum = 0;
            //    Console.WriteLine("Please insert numbers");
            //    for (var i = 0; i < len; i++)
            //    {
            //        Console.Write("{0}) => ", i);
            //        num = Convert.ToDecimal(Console.ReadLine());
            //        numbers[i] = num;
            //        sum += num;
            //    }
            //    Console.Clear();
            //    Console.WriteLine("Using for loop");
            //    Console.WriteLine("\tThe sum of an array is {0} and avarage is {1}", sum, sum / len);
            //    Console.Clear();
            //    sum = 0;
            //    Console.WriteLine("Using forEach loop");
            //    foreach (decimal j in numbers)
            //    {
            //        sum += j;
            //    }
            //    Console.WriteLine("\tThe sum of an array is {0} and avarage is {1}", sum, sum / len);
            //    Console.ReadLine();
            //}

            //Task 3
            //{
            //    int[] numArr = { 20, 92, 100, 55, 98, 1, 18, 26, 75, 33, 12 };
            //    int tmp;
            //    for(var i=0; i<numArr.Length; i++)
            //        {
            //        for (var j = i; j < numArr.Length; j++)
            //        {
            //            if(numArr[i] > numArr[j])
            //            {
            //                tmp = numArr[i];
            //                numArr[i] = numArr[j];
            //                numArr[j] = tmp;
            //            }
            //        }
            //    }
            //    Console.WriteLine(numArr);
            //    Console.ReadLine();
            //}

            //Task 4
            {
                Random rnd = new Random();
                int len = 100;
                int[] arr = new int[len];
                Console.WriteLine("Generating an array with random numbers");
                for (var i = 0; i < len; i++)
                {
                    arr[i] = rnd.Next(0, 1000);
                }
                int max = arr[0];
                int min = arr[0];
                for (var j = 1; j < arr.Length; j++)
                {
                    if (min >= arr[j])
                    {
                        min = arr[j];
                    }
                    if (max <= arr[j])
                    {
                        max = arr[j];
                    }
                }
                Console.WriteLine("Max is {0}, min is {1}", max, min);
                Console.WriteLine("!!! Result using built-in functions. \nMax is {0}, min is {1}", arr.Max(), arr.Min());
                Console.ReadLine();
            }
        }
    }
}
