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
            checked            {                int money = Convert.ToInt32(Console.ReadLine()); //100.000
                short takeInt = (short)money;                unchecked                {                    byte age = Convert.ToByte(Console.ReadLine()); //200
                    sbyte takeByte = (sbyte)age;                }            }

        }
    }
}
