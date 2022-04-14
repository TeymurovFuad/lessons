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

            //Task 1
            //{
            //    Console.WriteLine("Please insert 2 numbers");

            //    Console.WriteLine("Number a");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Number b");
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    int tmp = a;
            //    a = b;
            //    b = tmp;
            //}

            //Task 2
            //{
            //    Console.Clear();
            //    Console.WriteLine("Number a");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Number b");
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Number c");
            //    int c = Convert.ToInt32(Console.ReadLine());
            //    int sum = a + b + c;
            //    int sub = a - b - c;
            //    int mult = a * b * c;
            //    decimal div = (decimal)a / b / c;
            //    Console.WriteLine("{0}+{1}+{2}={3}", a,b,c,sum);
            //    Console.WriteLine("{0}-{1}-{2}={3}", a,b,c,sub);
            //    Console.WriteLine("{0}x{1}x{2}={3}", a,b,c,mult);
            //    Console.WriteLine("{0}:{1}:{2}={3}", a,b,c,div);
            //    Console.ReadLine();
            //}

            //Task 3
            {
                Console.Clear();
                Console.WriteLine("Insert a");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert b");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert c");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert d");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert e");
                int e = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert f");
                int f = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert g");
                int g = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert h");
                int h = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert i");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert k");
                int k = Convert.ToInt32(Console.ReadLine());

                int sum = a + b + c + d + e + f + g + h + i + k;
                int sub = a - b - c - d - e - f - g - h - i - k;
                long mult = a * b * c * d * e * f * g * h * i * k;
                double div = (double)a / b / c / d / e / f / g / h / i / k;

                Console.WriteLine("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}+{8}+{9}={10}",a,b,c,d,e,f,g,h,i,k,sum);
                Console.WriteLine("{0}", sum--);
                Console.WriteLine("{0}", sum++);
                Console.WriteLine("sum-- = {0}", --sum);
                Console.WriteLine("sum++ = {0}", ++sum);
                Console.WriteLine("{0}-{1}-{2}-{3}-{4}-{5}-{6}-{7}-{8}-{9}={10}", a, b, c, d, e, f, g, h, i, k, sub);
                Console.WriteLine("sub++ = {0}", ++sub);
                Console.WriteLine("sub++ = {0}", --sub);
                Console.WriteLine("{0}x{1}x{2}x{3}x{4}x{5}x{6}x{7}x{8}x{9}={10}", a, b, c, d, e, f, g, h, i, k, mult);
                Console.WriteLine("({0}x{1}x{2}x{3}x{4}x{5}x{6}x{7}x{8}x{9})x20={10}", a, b, c, d, e, f, g, h, i, k, mult *20);
                Console.WriteLine("({0}x{1}x{2}x{3}x{4}x{5}x{6}x{7}x{8}x{9}):20={10}", a, b, c, d, e, f, g, h, i, k, mult /20);
                Console.WriteLine("{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}:{8}:{9}={10}", a, b, c, d, e, f, g, h, i, k, div);
                Console.WriteLine("({0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}:{8}:{9})x20={10}", a, b, c, d, e, f, g, h, i, k, div *20);
                Console.WriteLine("({0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}:{8}:{9}):20={10}", a, b, c, d, e, f, g, h, i, k, div /20);
                Console.ReadLine();
            }

        }
    }
}
