using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //{
            //start_over:
            //    Console.Clear();
            //    SortedList<int, string> operationsList = new SortedList<int, string>()
            //{
            //    {1,"Add"},
            //    {2,"Show"},
            //    {3,"Search"},
            //    {4,"Edit"},
            //    {5,"Remove"},
            //    {6,"Exit"}
            //};
            //    Console.WriteLine("List of available operations. \nPlease select operation by its number");
            //    foreach (var operation in operationsList)
            //    {
            //        Console.WriteLine($"{operation.Key} - {operation.Value}");
            //    }
            //    int userOperation = Convert.ToInt32(Console.ReadLine());
            //    while (!operationsList.ContainsKey(userOperation))
            //    {
            //        Console.WriteLine("Opearation does not exist. Please try select again");
            //        userOperation = Convert.ToInt32(Console.ReadLine());
            //    }


            //    switch (operationsList[userOperation])
            //    {
            //        case "Add":
            //            Console.Write("Please insert number of an operation: ");
            //            int operID = Convert.ToInt32(Console.ReadLine());
            //            if (operationsList.ContainsKey(operID))
            //            {
            //                Console.WriteLine("Operation with this number already exists. Try again");
            //                goto case "Add";
            //            }
            //            Console.Write("Please insert name of an operation: ");
            //            string operName = Console.ReadLine();
            //            if (operationsList.ContainsValue(operName))
            //            {
            //                Console.WriteLine("Operation with this number already exists. Try again");
            //                goto case "Add";
            //            }
            //            operationsList.Add(operID, operName);
            //            Console.WriteLine("Operation added");
            //            Console.ReadLine();
            //            goto start_over;
            //        case "Show":
            //            foreach (var operation in operationsList)
            //            {
            //                Console.WriteLine($"{operation.Key}. Element = {operation.Value}");
            //            }
            //            Console.WriteLine("Press enter to continue");
            //            Console.ReadLine();
            //            goto start_over;
            //        case "Search":
            //            Console.WriteLine("Write the name of element you want to find");
            //            string searchOper = Console.ReadLine();
            //            if (operationsList.ContainsValue(searchOper))
            //            {
            //                Console.WriteLine($"Element {searchOper} found at index {operationsList.IndexOfValue(searchOper)}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Element not found");
            //            }
            //            Console.ReadLine();
            //            goto start_over;
            //        case "Edit":
            //            Console.Write("Please insert the name of the element you want to edit: ");
            //            string editOper = Console.ReadLine();
            //            if (operationsList.ContainsValue(editOper))
            //            {
            //                Console.WriteLine("Element found. Please write new name for an element");
            //                string newName = Console.ReadLine();
            //                //operationsList.GetKey(operationsList.IndexOfValue(newName));
            //            }
            //            else
            //            {
            //                Console.WriteLine("Element not found");
            //            }
            //            Console.ReadLine();
            //            goto start_over;
            //        case "Remove":
            //            Console.WriteLine("Do you want to remove all elements ? Y/yes|N/no");
            //            string response = Console.ReadLine();
            //            if (response.ToLower() == "y" || response.ToLower() == "yes")
            //            {
            //                operationsList.Clear();
            //                Console.WriteLine("Data successfully removed");
            //            }
            //            else
            //            {

            //                Console.WriteLine("Insert the name of the element you want to remove");
            //                string removeOper = Console.ReadLine();
            //                if (operationsList.ContainsValue(removeOper))
            //                {
            //                    operationsList.RemoveAt(operationsList.IndexOfValue(removeOper));
            //                    Console.WriteLine($"{removeOper} successfully removed");
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"{removeOper} does not exist");
            //                }

            //            }
            //            Console.ReadLine();
            //            goto start_over;
            //        case "Exit":
            //            Console.WriteLine("Bye");
            //            break;
            //        default:
            //            Console.WriteLine("Wront input");
            //            break;
            //    }
            //    Console.ReadLine();
            //}

            //Task 2
            {
                List<string> eng = new List<string>();
                List<string> az = new List<string>();
                Hashtable hasTable = new Hashtable()
                {
                    { "Eng", eng },
                    { "Az", az }
                };
                
            }
        }
    }
}
