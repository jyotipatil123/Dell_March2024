//// functions demo
//// static functions


////using System;

////namespace ConsoleApp_Dell2024
////{
////    class functions_demo
////    {
////        static void Main(string[] args)
////        {
////            Console.WriteLine("Enter first number : ");
////            int num1 = int.Parse(Console.ReadLine());

////            Console.WriteLine("Enter second number : ");
////            int num2 = int.Parse(Console.ReadLine());

////            add(num1, num2);

////            Console.ReadLine();
////        }

////        static void add(int num1, int num2) 
////        {
////            Console.WriteLine("Addition result is : "+(num1+num2));
////        }
////    }
////}


////=============================================================================================

////using System;

////namespace ConsoleApp_Dell2024
////{
////    class functions_demo
////    {
////        static void Main(string[] args)
////        {
////            Console.WriteLine("Enter first number : ");
////            int num1 = int.Parse(Console.ReadLine());

////            Console.WriteLine("Enter second number : ");
////            int num2 = int.Parse(Console.ReadLine());

////            A.add(num1, num2);

////            Console.ReadLine();
////        }
////    }

////    class A
////    { 
////       public static void add(int num1, int num2)
////        {
////            Console.WriteLine("Addition result is : " + (num1 + num2));
////        }      
////    }
////}

////====================================================================

////using System;

////namespace ConsoleApp_Dell2024
////{
////    class functions_demo
////    {
////        static void Main(string[] args)
////        {
////            Console.WriteLine("Enter first number : ");
////            int num1 = int.Parse(Console.ReadLine());

////            Console.WriteLine("Enter second number : ");
////            int num2 = int.Parse(Console.ReadLine());

////            functions_demo obj = new functions_demo();  
////            obj.add(num1, num2);

////            Console.ReadLine();
////        }
////       public void add(int num1, int num2)
////        {
////            Console.WriteLine("Addition result is : " + (num1 + num2));
////        }
////    }
////}
////=====================================================================

//// returning values

//using System;

//namespace ConsoleApp_Dell2024
//{
//    class functions_demo
//    {
//        static void Main(string[] args)
//        {
//            // calculator program 
//            Console.WriteLine("Enter first number : ");
//            int num1 = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter second number : ");
//            int num2 = int.Parse(Console.ReadLine());

//            functions_demo obj = new functions_demo();
//            Console.WriteLine("Addition result is ; "+obj.add(num1, num2));
//            Console.WriteLine("Subtraction result is ; " + obj.subtract(num1, num2));
//            Console.WriteLine("Multiplication  result is ; " + obj.multiply(num1, num2));
//            Console.WriteLine("Division result is ; " + obj.divide(num1, num2));

//            Console.ReadLine();
//        }
//        public int add(int num1, int num2)
//        { 
//            return (num1 + num2);
//        }
//        public int subtract(int num1, int num2) 
//        {
//            return (num1 - num2);
//        }
//        public int multiply(int num1, int num2) 
//        {
//            return (num1 * num2); 
//        }
//        public int divide(int num1, int num2) 
//        {
//            return (num1 / num2); 
//        }

//    }
//}
