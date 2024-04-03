// Lists in c#
using System;
using System.Collections.Generic;


namespace ConsoleApp_Dell2024
{
     class lists_demo
    {
        static void Main(string[] args)
        {
            List<int> obj = new List<int>();
            obj.Add(101);
            obj.Add(200);
            obj.Add(312);

            Console.WriteLine("List elements are : ");
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }

            //obj.Clear();   // clear all the items from List
            //Console.WriteLine("List elements are : ");
            //foreach (var item in obj)
            //{
            //    Console.WriteLine(item);
            //}

            obj.Remove(312);
            Console.WriteLine("Now the list elements are :");
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }









            Console.ReadLine();
        }
    }
}
