using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Dell_2024_demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            add obj= new add();
            obj.addition(10, 2);
            
            sub obj1= new sub();
            obj1.subtraction(10,2);

            Console.ReadLine();
        }
    }
}
