using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number of total students");
            int total = Convert.ToInt32(Console.ReadLine());
            string[] stundetList = new string[total];
            int loop = 0;
            while (loop != total)
            {
                Console.WriteLine("Insert the name of {0}. student", loop+1);
                stundetList[loop] = Console.ReadLine();
                loop++;
                Console.Clear();
            }
 
            foreach(string student in stundetList)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();
        }
    }
}
