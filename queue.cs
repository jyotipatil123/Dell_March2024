//// Queue demo
//using System;
//using System.Collections.Generic;
//using System.Collections;

//namespace ConsoleApp_Dell2024
//{
//     class queuedemo
//    {
//        static void Main(string[] args)
//        {
//            Queue q1 = new Queue();  // FIFO  first in first out
//            q1.Enqueue(1);
//            q1.Enqueue(2);
//            q1.Enqueue(3);
//            q1.Enqueue(4);

//            Console.WriteLine("Queue elements are : ");
//            foreach (var item in q1)
//            {
//                Console.WriteLine(item);
//            }

//            q1.Dequeue();
//            Console.WriteLine("After Dequeue Queue elements are : ");
//            foreach (var item in q1)
//            {
//                Console.WriteLine(item);
//            }

//            // clear the queue
//            //q1.Clear();

//            Console.WriteLine("Queue count is : "+ q1.Count);

//            Console.WriteLine("queue top most element :" + q1.Peek());

//            Console.WriteLine("Does queue contain 100 ? " + q1.Contains(100));

//            int[] arr1 = new int[10];

//            q1.CopyTo(arr1, 0);

//            Console.WriteLine("Copy to() demo : ");
//            foreach(var item in arr1)
//            {
//                Console.WriteLine(item);
//            }

//            // -----------
//            int[] arr2 =new int[5];

//            q1.ToArray().CopyTo(arr2, 0);

//            Console.WriteLine("ToArray() demo : ");
//            foreach (var item in arr2)
//            {
//                Console.WriteLine(item);
//            }




//            Console.ReadLine();
//        }
//    }
//}
