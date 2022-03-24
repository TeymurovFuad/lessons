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
            Program p = new Program();
            p.GetUserData();
            string[] cities = p.GetCities();
            p.ShowCitiesInColumn(cities);
            p.ShowCitiesInLine(cities);


        }

        public void GetUserData()
        {
            Console.WriteLine("Task 1");
            string firstName = "";
            string lastName = "";
            string city = "";
            Console.WriteLine("Please write your name");
            do
            {
                firstName = Console.ReadLine();
                if (String.IsNullOrEmpty(lastName))
                {
                    Console.WriteLine("Cannot be empty");
                }
            }
            while (String.IsNullOrEmpty(firstName));

            Console.WriteLine("Please write your surname");
            do
            {
                lastName = Console.ReadLine();
                if (String.IsNullOrEmpty(lastName))
                {
                    Console.WriteLine("Cannot be empty");
                }   
            }
            while (String.IsNullOrEmpty(lastName));

            Console.WriteLine("Please write your city");
            do
            {
                city = Console.ReadLine();
                if (String.IsNullOrEmpty(lastName))
                {
                    Console.WriteLine("Cannot be empty");
                }
            }
            while (String.IsNullOrEmpty(city));

            Console.WriteLine(String.Format("{0} {1} lives in {2}", firstName, lastName, city));
            Console.ReadLine();
        }

        public string[] GetCities()
        {
            int count = 10;
            string[] cities = new string[count];

            Console.WriteLine("Please insert the name of "+count.ToString()+" cities");
            while(count != 0)
            {
                Console.WriteLine(String.Format("City {0}", count));
                string tmp = Console.ReadLine();
                if (String.IsNullOrEmpty(tmp) || cities.Contains(tmp))
                {
                    Console.WriteLine("Can't be dublicate or empty");
                    continue;
                }
                cities[count-1] = tmp;
                count--;
            }

            return cities;
        }

        public void ShowCitiesInColumn(string[] cities)
        {
            int i = 0;
            foreach(string city in cities)
            {
                i++;
                Console.WriteLine(String.Format("City #{0}: {1}", i, city));
            }
            Console.ReadLine();
        }

        public void ShowCitiesInLine(string[] cities)
        {
            Console.Write("List of cities: ");
            Console.Write(String.Join(", ", cities));
            Console.ReadLine();
        }
    }
}
