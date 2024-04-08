////// Lists in c#
////using System;
////using System.Collections.Generic;


////     class lists_demo
////    {
////        static void Main(string[] args)
////        {
////            List<int> obj = new List<int>();
////            obj.Add(101);
////            obj.Add(200);
////            obj.Add(312);

////            Console.WriteLine("List elements are : ");
////            foreach (var item in obj)
////            {
////                Console.WriteLine(item);
////            }

////            //obj.Clear();   // clear all the items from List
////            //Console.WriteLine("List elements are : ");
////            //foreach (var item in obj)
////            //{
////            //    Console.WriteLine(item);
////            //}

////            obj.Remove(312);
////            Console.WriteLine("Now the list elements are :");
////            foreach (var item in obj)
////            {
////                Console.WriteLine(item);
////            }
////            //=================================================

////        List<string> list1 = new List<string>();
////        list1.Add("AP");
////        list1.Add("Kolkata");
////        list1.Add("Gujrat");
////        list1.Add("karnataka");

////        foreach (var i in list1)
////        {
////            Console.WriteLine(i);
////        }
////        //==================================================
////        List<char> list2 = new List<char>();
////        list2.Add('a');
////        list2.Add('e');
////        list2.Add('i');
////        list2.Add('o');
////        list2.Add('u');

////        Console.WriteLine("All the vowels : ");
////        foreach (var item in list2)
////        {
////            Console.WriteLine(item);
////        }
////        Console.ReadLine();
////        }
////    }

//// collection class --stack

//using System;
//using System.Collections;
//using System.Collections.Generic;
//class MyClass
//{
//    static void Main(string[] args)
//    {
//        Stack s1= new Stack();   // LIFO  last in first out
//        s1.Push(1);
//        s1.Push(2);
//        s1.Push(3);
//        s1.Push(4);
//        s1.Push(5);

//        Console.WriteLine("Stack elements are : ");
//        foreach(var x in s1) 
//            Console.WriteLine(x);

//        s1.Pop();
//        Console.WriteLine("Stack elements after pop  : ");
//        foreach (var x in s1)
//            Console.WriteLine(x);

//     //   s1.Clear();  // clears all the items from stack

//        Console.WriteLine("Stack top is : "+ s1.Peek());  // displays stack top most element
//        s1.Pop();

//        Console.WriteLine("Stack elements are : ");
//        foreach (var x in s1)
//            Console.WriteLine(x);

//        Console.WriteLine("Contains : "+ s1.Contains(100));

//        Console.ReadLine();
//    }
//}